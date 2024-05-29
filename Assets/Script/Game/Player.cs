using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnEnable()
    {
        ActionManager.GameLoaded += GameLoadedFunc;
    }

    private void OnDisable()
    {
        ActionManager.GameLoaded -= GameLoadedFunc;
    }
   
    private void GameLoadedFunc()
    {
        IGameDataService gameDataService = ServiceLocator.Current.Get<IGameDataService>();
        PlayerData data = gameDataService.GetGameDataManager().GetPlayerData();
        data.currentHealt = 100f;
        Debug.Log(data.currentHealt);
    }

    
}
