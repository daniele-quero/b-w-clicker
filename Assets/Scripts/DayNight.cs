using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DayNight : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _playableDirector;

    private void OnEnable()
    {
        ClickBehaviour.OnClick += ActivateDayTimeCycle;
    }


    private void ActivateDayTimeCycle()
    {
       _playableDirector.Play();
    }
}
