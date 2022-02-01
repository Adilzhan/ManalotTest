using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(Animations.MoveToPos(transform, new Vector3(Screen.width, transform.position.y, 0),
            1.8f, OnFinishLineOrWindowClosed()));
    }

    private IEnumerator OnFinishLineOrWindowClosed()
    {
        DestroyImmediate(gameObject);
        yield break;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}