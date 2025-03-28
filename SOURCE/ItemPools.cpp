#include "pch.h"
#include "ItemPools.h"
#include "ItemData.h"
#include <iostream>
#include <fstream>

ItemPools::ItemPools()
{
	Load();
}

void ItemPools::Load()
{
	std::ifstream i("DATA/CONFIGS/ITEM_CONFIG.JSON");
	json itemData;
	itemData << i;

	for (int i = 0; i < (int)ItemType::PLACEHOLDER; i++)
	{
		ItemType type = (ItemType)i;
		if (type == NONE || type == BULLET_BILL || type == LIGHTNING_CLOUD || type == POW || type == LIGHTNING_BOLT) //Bullet Bills Are Part of the player class
		{
			continue;
		}

		std::string itemName = Locator::getItemData()->GetItemModelName(type);
		if (itemName == "DEFAULT_ITEM")
		{
			continue;
		}
		else if (type == FAKE_BOX)
		{
			itemName = "FAKE_BOX";
		}
		else if (type == SQUID)
		{
			itemName = "SQUID";
		}
		else
		{
			itemName.erase(itemName.begin(), itemName.begin() + 5); //Removing "ITEM_"
		}

		if (itemData[itemName]["implemented"])
		{
			DebugText::print("Creating " + itemName + " pool");
			CreateItemPool(type, itemData[itemName]["pool_size"]);
		}
	}
}

ItemPools::~ItemPools()
{
	Reset();
}

ItemMesh* ItemPools::GetItemMesh(ItemType _type)
{
	ItemMesh* itemMesh;
	if (!m_itemPoolMap[_type].m_itemMeshes.empty())
	{
		itemMesh = m_itemPoolMap[_type].m_itemMeshes.front();
		m_itemPoolMap[_type].m_itemMeshes.pop();
	}
	else
	{
		DebugText::print("Not enough " + Locator::getItemData()->GetItemModelName(_type) + " meshes in pool. Loading new mesh:");
		itemMesh = CreateItemMesh(_type);
	}
	return itemMesh;
}

void ItemPools::AddItemMesh(ItemType _type, ItemMesh* _mesh)
{
	_mesh->m_mesh->Reset();
	_mesh->m_mesh->SetOri(Matrix::Identity);
	_mesh->m_mesh->UpdateWorld();
	_mesh->m_displayedMesh->ResetRotation();
	_mesh->m_displayedMesh->ResetScale();
	_mesh->m_displayedMesh->Update(_mesh->m_mesh->GetWorld());
	m_itemPoolMap[_type].m_itemMeshes.push(_mesh);
}

AnimationController * ItemPools::GetExplosion(ItemType _type)
{
	AnimationController * explosion;

	if (_type == BOMB && !m_bombExplosions.empty())
	{
		explosion = m_bombExplosions.front();
		m_bombExplosions.pop();
	}
	else if (_type == BLUE_SHELL && !m_shellExplosions.empty())
	{
		explosion = m_shellExplosions.front();
		m_shellExplosions.pop();
	}
	else
	{
		explosion = CreateExplosion(_type);
	}

	return explosion;
}

void ItemPools::AddExplosion(AnimationController * _explosion, ItemType _type)
{
	_explosion->ResetRotation();
	_explosion->ResetScale();

	if (_type == BOMB)
	{
		m_bombExplosions.push(_explosion);
	}
	else if (_type == BLUE_SHELL)
	{
		m_shellExplosions.push(_explosion);
	}
}

void ItemPools::Reset()
{
	for (auto& kv : m_itemPoolMap)
	{
		while(!kv.second.m_itemMeshes.empty())
		{
			delete kv.second.m_itemMeshes.front();
			kv.second.m_itemMeshes.pop();
		}
	}

	while(!m_bombExplosions.empty())
	{
		delete m_bombExplosions.front();
		m_bombExplosions.pop();
	}
	
	while(!m_shellExplosions.empty())
	{
		delete m_shellExplosions.front();
		m_shellExplosions.pop();
	}
}

void ItemPools::CreateItemPool(ItemType _type, int _poolSize)
{
	ItemPool itemPool;
	itemPool.m_size = _poolSize;

	if (itemPool.m_size < 1)
	{
		return;
	}

	for (int i = 0; i < itemPool.m_size; i++)
	{
		itemPool.m_itemMeshes.push(CreateItemMesh(_type));

		if (_type == BOMB)
		{
			m_bombExplosions.push(CreateExplosion(BOMB));
		}
		else if (_type == BLUE_SHELL)
		{
			m_shellExplosions.push(CreateExplosion(BLUE_SHELL));
		}
	}

	m_itemPoolMap.insert(std::pair<ItemType, ItemPool>(_type, itemPool));
}

AnimationController * ItemPools::CreateExplosion(ItemType _type)
{
	AnimationController* explosion = new AnimationController();
	explosion->AddModel("Explosion", _type == BOMB ? "bomb_explosion" : "blue_shell_explosion");
	explosion->AddModelSet("default", std::vector<std::string>{"Explosion"});
	explosion->SwitchModelSet("default");
	explosion->Load();
	return explosion;
}

ItemMesh * ItemPools::CreateItemMesh(ItemType _type)
{
	ItemMesh* itemMesh = new ItemMesh();
	itemMesh->m_mesh = std::make_unique<TrackMagnet>(Locator::getItemData()->GetItemModelName(_type));
	itemMesh->m_mesh->SetShouldRender(false);
	itemMesh->m_displayedMesh = std::make_unique<AnimationController>();
	itemMesh->m_displayedMesh->AddModel("item", Locator::getItemData()->GetItemModelName(_type));
	itemMesh->m_displayedMesh->AddModelSet("default", std::vector<std::string>{"item"});
	itemMesh->m_displayedMesh->SwitchModelSet("default");
	itemMesh->m_displayedMesh->Load();
	return itemMesh;
}
