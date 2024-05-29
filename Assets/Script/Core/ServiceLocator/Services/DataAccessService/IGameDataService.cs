using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameDataService : IGameService
{
    IDataManager GetGameDataManager();
}
