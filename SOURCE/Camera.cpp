#include "pch.h"
#include "Camera.h"
#include "GameStateData.h"
#include "CameraData.h"
#include "RaceManager.h"
#include "Player.h"
#include "Keyboard.h"
#include "KeybindManager.h"
#include <math.h>

Camera::Camera(float _width, float _height, Vector3 _dpos, GameObject3D * _target, CameraType _behav = CameraType::FOLLOW) : cam_type (_behav)
{
	m_pos = Vector3::Backward;
	m_proj = Matrix::CreatePerspectiveFieldOfView(Locator::getCD()->fovs[static_cast<int>(cam_type)], _width / _height, Locator::getCD()->m_near, Locator::getCD()->m_far);
	m_targetObject = _target;
	width = _width;
	height = _height;
}

void Camera::ResetFOV()
{
	if (cam_type != CameraType::CINEMATIC)
	{
		if(Locator::getRM()->player_amount != 2)
			m_proj = Matrix::CreatePerspectiveFieldOfView(Locator::getCD()->fovs[static_cast<int>(cam_type)], width / height, Locator::getCD()->m_near, Locator::getCD()->m_far);
		else
			m_proj = Matrix::CreatePerspectiveFieldOfView(Locator::getCD()->fovs[static_cast<int>(cam_type)], width * 0.5f / height, Locator::getCD()->m_near, Locator::getCD()->m_far);
	}
}

void Camera::Tick()
{
	Vector3 look_at_target;
	Vector3 target_pos;
	Vector3 up_transform;
	Matrix orientation;
	float rot_lerp;
	float pos_lerp;

	bool checker = true;

#ifdef _DEBUG
	checker = cam_type != CameraType::DEBUG_CAM;
#endif // DEBUG


	if (checker)
	{
		m_dpos = Locator::getCD()->camera_offsets[static_cast<int>(cam_type)];
		orientation = m_targetObject ? m_targetObject->GetOri() : GetOri();
		look_at_target = (m_targetObject ? m_targetObject->GetPos() : Locator::getCD()->look_at_positions[static_cast<int>(cam_type)]) + Vector3::Transform(Locator::getCD()->look_at_offsets[static_cast<int>(cam_type)], orientation);
		target_pos = (m_targetObject ? m_targetObject->GetPos() : Locator::getCD()->target_positions[static_cast<int>(cam_type)]) + Vector3::Transform(m_dpos, orientation);
		up_transform = m_targetObject ? m_targetObject->GetWorld().Up() : Vector3::Up;
		rot_lerp = Locator::getCD()->rotation_lerps[static_cast<int>(cam_type)];
		pos_lerp = Locator::getCD()->position_lerps[static_cast<int>(cam_type)];
	}

	switch (cam_type)
	{
	case CameraType::ORBIT:
	{
		angle += (Locator::getCD()->orbit_spin_amount * Locator::getGSD()->m_dt);
		target_pos = (m_targetObject ? m_targetObject->GetPos() : Locator::getCD()->target_positions[static_cast<int>(cam_type)]) +
			Vector3::Transform({ sin(angle / 57.2958f) * m_dpos.x, m_dpos.y, cos(angle / 57.2958f) * m_dpos.z }, orientation);

		break;
	}
	case CameraType::CINEMATIC:
	{
		timer += Locator::getGSD()->m_dt;
		look_at_target = m_targetPos;
		up_transform = Vector3::Up;

		if (cam_point < Locator::getCD()->points.size() && Locator::getCD()->look_points[cam_point] != Vector3{0, 0, 0})
		{
			target_pos = Vector3::Lerp(Locator::getCD()->points[cam_point][0], Locator::getCD()->points[cam_point][1], timer / Locator::getCD()->cine_time_out);
			m_targetPos = Locator::getCD()->look_points[cam_point];

			if (timer >= Locator::getCD()->cine_time_out)
			{
				timer = 0.0f;
				cam_point++;
			}
		}
		break;
	}
	case CameraType::INDEPENDENT:
	{
		if (m_keybinds.keyHeld("CAM_LEFT", m_cameraID))
			indep_angle_x += Locator::getCD()->indep_spin_amount;
		else if (m_keybinds.keyHeld("CAM_RIGHT"), m_cameraID)
			indep_angle_x -= Locator::getCD()->indep_spin_amount;

		if (m_keybinds.keyHeld("CAM_UP", m_cameraID) && indep_angle_y > -88)
			indep_angle_y -= Locator::getCD()->indep_spin_amount;
		else if (m_keybinds.keyHeld("CAM_DOWN", m_cameraID) && indep_angle_y < 88)
			indep_angle_y += Locator::getCD()->indep_spin_amount;

		target_pos = (m_targetObject ? m_targetObject->GetPos() : Locator::getCD()->target_positions[static_cast<int>(cam_type)]) + 
			Vector3::Transform({ sin(indep_angle_x / 57.2958f) * m_dpos.x, 
				sin(indep_angle_y / 57.2958f) * m_dpos.y, 
				cos(indep_angle_x / 57.2958f) * m_dpos.z }, orientation);
		break;
	}
#ifdef _DEBUG
	case CameraType::DEBUG_CAM:
	{
		float cam_speed = Locator::getCD()->cam_speed;
		if (m_keybinds.keyHeld("DEBUG_CAM_ACCELERATE"))
		{
			cam_speed *= 1.1f;
		}

		Vector3 forwardMove = cam_speed * m_world.Forward();
		Vector3 rightMove = cam_speed * m_world.Right();
		Vector3 upMove = cam_speed * m_world.Up();
		Matrix rotMove = Matrix::CreateRotationY(m_yaw);

		forwardMove = Vector3::Transform(forwardMove, rotMove);
		rightMove = Vector3::Transform(rightMove, rotMove);
		upMove = Vector3::Transform(upMove, rotMove);
		m_targetPos = m_pos + forwardMove;


		float mouse_xpos = last_mouse_xpos - Locator::getID()->m_mouseState.x;
		float mouse_ypos = last_mouse_ypos - Locator::getID()->m_mouseState.y;
		//m_yaw -= cam_rot_speed * Locator::getID()->m_mouseState.x;
		//m_pitch -= cam_rot_speed * Locator::getID()->m_mouseState.y;
		m_yaw += Locator::getCD()->cam_rot_speed * mouse_xpos;
		m_pitch += Locator::getCD()->cam_rot_speed * mouse_ypos;

		if (m_pitch > 1.5f)
			m_pitch = 1.49f;
		else if (m_pitch < -1.5f)
			m_pitch = -1.49f;

		last_mouse_xpos = Locator::getID()->m_mouseState.x;
		last_mouse_ypos = Locator::getID()->m_mouseState.y;

		if (m_keybinds.keyHeld("debug cam forward"))
		{
			m_pos += Locator::getGSD()->m_dt * forwardMove;
			m_targetPos += Locator::getGSD()->m_dt * forwardMove;
		}
		else if (m_keybinds.keyHeld("debug cam backward"))
		{
			m_pos -= Locator::getGSD()->m_dt * forwardMove;
			m_targetPos -= Locator::getGSD()->m_dt * forwardMove;
		}

		if (m_keybinds.keyHeld("debug cam left"))
		{
			m_pos -= Locator::getGSD()->m_dt * rightMove;
			m_targetPos -= Locator::getGSD()->m_dt * rightMove;
		}
		else if (m_keybinds.keyHeld("debug cam right"))
		{
			m_pos += Locator::getGSD()->m_dt * rightMove;
			m_targetPos += Locator::getGSD()->m_dt * rightMove;
		}

		if (m_keybinds.keyHeld("debug cam up"))
		{
			m_pos -= Locator::getGSD()->m_dt * upMove;
			m_targetPos -= Locator::getGSD()->m_dt * upMove;
		}
		else if (m_keybinds.keyHeld("debug cam down"))
		{
			m_pos += Locator::getGSD()->m_dt * upMove;
			m_targetPos += Locator::getGSD()->m_dt * upMove;
		}

		if (m_keybinds.keyHeld("debug cam look up") && m_pitch > -1.5)
			m_pitch += Locator::getCD()->cam_rot_speed;
		else if (m_keybinds.keyHeld("debug cam look down") && m_pitch < 1.5)
			m_pitch -= Locator::getCD()->cam_rot_speed;

		if (m_keybinds.keyHeld("debug cam look left"))
			m_yaw += Locator::getCD()->cam_rot_speed;
		else if (m_keybinds.keyHeld("debug cam look right"))
			m_yaw -= Locator::getCD()->cam_rot_speed;

		m_view = Matrix::CreateLookAt(m_pos, m_targetPos, m_pos.Up);

		break;
	}
#endif
	}

#ifdef _DEBUG
	if (cam_type != CameraType::DEBUG_CAM)
	{
		m_view = Matrix::CreateLookAt(m_pos, look_at_target, up_transform);
		if (rotCam != orientation)
			rotCam = Matrix::Lerp(rotCam, orientation, rot_lerp);

		if (m_pos != target_pos)
			m_pos = Vector3::Lerp(m_pos, target_pos, pos_lerp);
	}

	//Debug output player location - useful for setting up spawns
	if (m_keybinds.keyReleased("Print Camera Location")) {
		DebugText::print("CAMERA POSITION: (" + std::to_string(m_pos.x) + ", " + std::to_string(m_pos.y) + ", " + std::to_string(m_pos.z) + ")");
	}
#else
	m_view = Matrix::CreateLookAt(m_pos, look_at_target, up_transform);
	if (rotCam != orientation)
		rotCam = Matrix::Lerp(rotCam, orientation, rot_lerp);

	if (m_pos != target_pos)
		m_pos = Vector3::Lerp(m_pos, target_pos, pos_lerp);
#endif

	//DebugText::print(std::to_string(timer));

	GameObject3D::Tick();
}

/* reset */
void Camera::Reset() {
	angle = 0.0f;
	indep_angle_x = 0.0f;
	indep_angle_y = 0.0f;
	cam_point = 0;
	timer = 0.0f;
	m_cameraID = 0;
}