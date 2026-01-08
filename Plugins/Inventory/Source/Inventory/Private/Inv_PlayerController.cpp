// Copyright Sylar129

#include "Inv_PlayerController.h"

#include "Inventory.h"

void AInv_PlayerController::BeginPlay()
{
	Super::BeginPlay();

	UE_LOG(LogInventory, Warning, TEXT("BeginPlay for PlayerController"));
}