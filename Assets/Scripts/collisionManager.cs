using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionManager : MonoBehaviour
{
    GameObject ExitSign, InspectSign, itemFound, EmptySign;
    string sceneToTransitTo;
    bool containsCollectible;
    bool collectibleCollected = false;

    collections collections;

    private void Start()
    {
        EmptySign = GameObject.Find("Empty").gameObject;
        itemFound = GameObject.Find("item found").gameObject;
        collections = gameObject.GetComponent<collections>();
        ExitSign = GameObject.Find("Enter").gameObject;
        InspectSign = GameObject.Find("Inspect");
        ExitSign.SetActive(false);
        InspectSign.SetActive(false);
        itemFound.SetActive(false);
        EmptySign.SetActive(false);
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
        if(collision.gameObject.name == "Desk")
        {
            InspectSign.SetActive(true);
            containsCollectible = true;
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

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InspectSign.activeInHierarchy)
            {
                if (containsCollectible)
                {
                    if (collectibleCollected)
                    {
                        EmptySign.SetActive(true);
                        InspectSign.SetActive(false);
                        return;
                    }
                    
                    collections.collectedItems.Add(collections.rareImage);
                    itemFound.SetActive(true);
                    InspectSign.SetActive(false);
                    containsCollectible = false;
                    collectibleCollected = true;
                }
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
        if (collision.gameObject.name == "Desk")
        {
            InspectSign.SetActive(false);
            EmptySign.SetActive(false);
            itemFound.SetActive(false);
        }
    }

    void loadScene(string sceneToLoad)
    {
        gameObject.transform.position = new Vector3(0, -4, 0);

        SceneManager.LoadSceneAsync(sceneToLoad);
    }
}
