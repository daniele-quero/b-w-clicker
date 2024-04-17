using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickBehaviour : MonoBehaviour, IPointerClickHandler
{
    public static Action OnClick;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked: " + eventData.pointerCurrentRaycast.gameObject.name);
        if (OnClick != null) 
            OnClick();

        gameObject.SetActive(false);
    }

}
