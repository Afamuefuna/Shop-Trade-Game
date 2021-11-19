using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepObjectAcrossScenes : MonoBehaviour
{
    private static keepObjectAcrossScenes _instance;
    public static keepObjectAcrossScenes Instance
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
