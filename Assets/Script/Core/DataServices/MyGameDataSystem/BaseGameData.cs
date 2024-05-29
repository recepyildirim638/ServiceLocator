using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameData : MonoBehaviour
{
    [Header("Game Data")]
    [SerializeField] protected DataContainer data;

    [Header("Behaviour")]
    protected PlayerData playerData;
    protected LevelData levelData;
    protected MainData mainData;

    protected void LoadGameData()
    {
        SaveManager.LoadGameData(data);

        playerData = data.playerData;
        levelData = data.levelData;
        mainData = data.mainData;
    }
    public void SaveGameData()
    {
        data.playerData = playerData;
        data.levelData = levelData;
        data.mainData = mainData;

        SaveManager.SaveGameData(data);
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            SaveGameData();
        }
    }

    private void OnApplicationQuit()
    {
        SaveGameData();
    }
}
