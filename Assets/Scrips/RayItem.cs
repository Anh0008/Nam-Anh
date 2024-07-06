using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayItem : MonoBehaviour, iRayItem
{
    [SerializeField] Color deActiveColor;
    [SerializeField] Color activeColor;
    [SerializeField] Renderer gameObjectRenderer;
    public void Start()
    {
        //gameObjectRenderer = GetComponent<Renderer>();
        gameObjectRenderer.material.color = deActiveColor;
    }
    public void OnPointerEnter()
    {
        Debug.Log("OnPointerEnter");
        gameObjectRenderer.material.color = activeColor;
        UIManager.Instance.ShowInfoPanel(gameObject, transform.position);
    }

    public void OnPointerExit()
    {
        Debug.Log("OnPointerExit");
    }

}
