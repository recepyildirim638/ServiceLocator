using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/Game Data", order = 1)]
public class DataContainer : ScriptableObject
{
    [Header("Player Data")]
    public PlayerData playerData = new PlayerData();
    [Header("Level Data")]
    public LevelData levelData = new LevelData();
    [Header("Main Data")]
    public MainData mainData = new MainData();

    public void ResetData()
    {
        mainData.vibration = true;
        mainData.sound = true;
        mainData.music = true;

        playerData.level = 0;
        playerData.moneyValue = 0f;
        playerData.currentHealt = 100f;

        levelData.level = 0;
        levelData.realLevel = 0;
       

        PlayerPrefs.DeleteAll();
        SaveManager.SaveGameData(this);
    }


    public void Save()
    {
        SaveManager.SaveGameData(this);
    }
}
