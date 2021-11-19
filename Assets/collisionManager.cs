using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionManager : MonoBehaviour
{
    GameObject ExitSign;
    string sceneToTransitTo;

    private void Start()
    {
        ExitSign = GameObject.Find("Leave").gameObject;
        ExitSign.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Home door")
        {
            ExitSign.SetActive(true);
            sceneToTransitTo = "Home";
        }
        if (collision.gameObject.name == "Shop door")
        {
            ExitSign.SetActive(true);
            sceneToTransitTo = "Shop";
        }
        if (collision.gameObject.name == "Street exit")
        {
            ExitSign.SetActive(true);
            sceneToTransitTo = "Street";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ExitSign.activeInHierarchy)
            {
                loadScene(sceneToTransitTo);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Home door")
        {
            ExitSign.SetActive(false);
        }
        if (collision.gameObject.name == "Shop door")
        {
            ExitSign.SetActive(false);
        }
        if (collision.gameObject.name == "Street exit")
        {
            ExitSign.SetActive(false);
        }
    }

    void loadScene(string sceneToLoad)
    {
        gameObject.transform.position = new Vector3(0, -4, 0);

        SceneManager.LoadSceneAsync(sceneToLoad);
    }
}
