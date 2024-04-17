using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private int _count;
    [SerializeField]
    private Text _text;
    private void OnEnable()
    {
        
    ClickBehaviour.OnClick += UpdateCount;

        
    }

    private void UpdateCount()
    {
        _count++;
        _text.text = _count.ToString();
    }
}
