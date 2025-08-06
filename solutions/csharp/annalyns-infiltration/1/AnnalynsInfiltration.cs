static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => 
        !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => 
        (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : 
        false;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => 
        (prisonerIsAwake && !archerIsAwake) ? true : 
        false;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => 
        (petDogIsPresent && !archerIsAwake /*&& (prisonerIsAwake || !prisonerIsAwake) && (knightIsAwake || !knightIsAwake)*/) ? true :
        ((!petDogIsPresent && prisonerIsAwake) && (!archerIsAwake && !knightIsAwake)) ? true : 
        false;
}

    