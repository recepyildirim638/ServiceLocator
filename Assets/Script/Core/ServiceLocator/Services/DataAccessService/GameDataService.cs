using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameDataService : IGameDataService
{
    private IDataManager dataManager;

    public IDataManager GetGameDataManager()
    {
        if (dataManager == null)
            dataManager = Object.FindObjectOfType<MyGameDataManager>();

        return dataManager;
    }
}
