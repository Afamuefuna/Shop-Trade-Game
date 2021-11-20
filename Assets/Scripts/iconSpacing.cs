using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iconSpacing : MonoBehaviour
{
    [SerializeField] VerticalLayoutGroup VerticalLayout;
    [SerializeField] float spacing;

    // Start is called before the first frame update
    void Start()
    {
        VerticalLayout = gameObject.transform.GetComponentInParent<VerticalLayoutGroup>();
        VerticalLayout.spacing = spacing;
    }
}
