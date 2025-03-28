#include "pch.h"
#include "Skybox.h"
#include "RenderData.h"
#include "DeviceData.h"
#include "FindMedia.h"
#include "RenderData.h"
#include "GameObjectShared.h"
#include <codecvt>

Skybox::~Skybox() {
	Reset();
}

/* Load skybox */
void Skybox::Load() {
	#ifndef _ARCADE
	//Create model with material override
	model = new SDKMeshGO3D(Locator::getGOS()->common_model_config["skybox"]);
	model->DisableDepthDefault();
	model->Load();
	model->AlbedoEmissiveOverride(Locator::getRD()->current_cubemap_skybox);
	#endif
}

/* Render skybox */
void Skybox::Render() {
	if (model != nullptr) {
		model->SetPos(Locator::getRD()->m_cam->GetPos());
		model->Tick();
		model->Render();
	}
}

/* Reset skybox */
void Skybox::Reset() {
	#ifndef _ARCADE
	delete model;
	model = nullptr;
	skybox_resources.reset();
	#endif
}