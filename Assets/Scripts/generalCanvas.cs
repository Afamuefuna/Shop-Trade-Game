using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generalCanvas : MonoBehaviour
{
    private static generalCanvas _instance;
    public static generalCanvas Instance
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
