using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseSaver : MonoBehaviour
{
    private static DatabaseSaver _instance;
    public static DatabaseSaver Instance
    {
        get;
        set;
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
