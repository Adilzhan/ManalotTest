using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Window : MonoBehaviour
{
    public GameObject circlePrefab;
    public RectTransform windowSize;


    private void OnEnable()
    {
        windowSize.sizeDelta = new Vector2(Screen.width * 0.4f, Screen.height * 0.4f);
        StartCoroutine(Animations.ScaleToSize(windowSize, new Vector2(Screen.width, Screen.height),
            1.5f, CreateCircles()));
    }

    private IEnumerator CreateCircles()
    {
        while (gameObject.activeInHierarchy)
        {
            yield return new WaitForSeconds(0.5f);
            var circleGO = Instantiate(circlePrefab, new Vector3(0, Screen.height / 2, 0), Quaternion.identity,
                transform);
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
    }
}