using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    #region Singleton
    public static Database instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
    }
    #endregion

    [SerializeField] Tower[] towerList;
    public Tower GetTowerById(int id)
    {
        foreach (Tower tower in towerList)
            if (tower.id == id)
                return tower;

        return null;
    }
}
