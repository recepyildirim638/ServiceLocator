using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataManager
{
    void Initalize();
    PlayerData GetPlayerData();
    LevelData GetLevelData();
    MainData GetMainData();
}
