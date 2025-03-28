#pragma once
#include "PhysModel.h"
#include "Track.h"
#include "ControlledMovement.h"
#include <vector>

class MoveAI
{
public:
	MoveAI(PhysModel* _model, ControlledMovement* _move);
	~MoveAI();

	virtual bool Update();
	void RecalculateLine(Track* _track);
	void DebugRender();

	void UseDrift(bool _flag) { m_useDrift = _flag;};
	void SetAutoUpdateWaypoints(bool _autoUpdate) { m_autoUpdateWaypoints = _autoUpdate; };

	struct RouteNode
	{
		RouteNode() = default;
		RouteNode(const Vector3& _pos, const size_t& _way) : position(_pos), waypoint(_way) {};
		Vector3 position;
		size_t waypoint;
	};

protected:
	std::vector<RouteNode> m_route;
	size_t m_routeIndex = 0;
	Player* m_player = nullptr;

private:
	bool FindRoute(Track* _track, Matrix& _world, Vector3& _pos, Vector3& _direction, int _iterations, bool _allowTurn, int _waypointIndex);
	int FindWorld(Track* _track, const Matrix& _startWorld, Matrix& _endWorld, const Vector3& _startPos, Vector3& _endPos, Vector3 _direction, const int& _steps, const int& _iteration, int &_waypointIndex);

	PhysModel* m_model = nullptr;
	ControlledMovement* m_move = nullptr;
	Track* m_track = nullptr;

	float m_aiPathStep = 4;
	int m_maxPathIterations = 20;
	bool m_offTrack = false;

	bool m_useDrift = false;

	int m_waypointPos = 0;

	float m_lineLeeway = 0.2f; // The amount of leeway allowed between the current velocity and the driving line before the kart turns
	float m_driftThreshold = 0.5f; // The minimum angle between the current veloicty and the diriving line that we start a drift
	float m_wayPointHitRadius = 1; // Radius for the "hit box" of the waypoint where the kart will move onto the next one

	std::vector<SDKMeshGO3D*> m_debugRaceLine;
	std::vector<SDKMeshGO3D*> m_debugNextWaypoint;

	int m_minFrontSpace = 10; // The minimum number of m_aiPathStep iterations required to be in front of the object, after which the AI turns
	int m_minSideSpace = 1; // The minimum number of m_aiPathStep buffer space between the object and the side of the track

	float m_deflectionLimit = 2; // The maximum deflection allowed when merging waypoint nodes

	bool m_autoUpdateWaypoints = false;

	int m_findTrackMaxSteps = 10; // The maximum steps to take while searching for track


	bool m_goingBackToTrack = false;
	float m_timeOffTrack = 0;
	float m_maxTimeOffTrack = 2;

	Vector3 m_wayMiddle = Vector3::Zero;
};