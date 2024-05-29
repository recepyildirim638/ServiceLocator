using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameDataManager : BaseGameData, IDataManager
{
    public void Initalize() => LoadGameData();
    public PlayerData GetPlayerData() => this.playerData;
    public LevelData GetLevelData() => this.levelData;
    public MainData GetMainData() => this.mainData;
}



