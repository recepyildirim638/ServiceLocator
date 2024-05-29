using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    private void Awake()
    {
        Initalize();
    }

    private void Initalize()
    {
        ServiceLocator.Current.Get<IGameDataService>().GetGameDataManager().Initalize();
        ActionManager.GameLoaded.Invoke();
    }
}
