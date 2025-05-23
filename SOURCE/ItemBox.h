#pragma once

#include "PhysModel.h"
#include "SimpleMath.h"
#include <iostream>

class Player;

class ItemBox : public PhysModel {
public:
	ItemBox(Vector3& position, Vector3& rotation);
	~ItemBox() = default;

	void hasCollided();

	virtual void Tick() override;

private:
	double invisibility_timer = 0.0;
};