using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public enum Activity
    {
        onIntro,
        onTask,
        onTaskComplete
    }

    public Activity currentActivity = Activity.onIntro;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject GameManager = new GameObject();
                    GameManager.name = "GameManager";
                    _instance = GameManager.AddComponent<GameManager>();
                    DontDestroyOnLoad(GameManager);
                }
            }
            return _instance;
        }
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
