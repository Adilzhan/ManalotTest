using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public static IEnumerator ScaleToSize(RectTransform rect, Vector2 endSize, float animation_duration,
        IEnumerator endAction = null)
    {
        var startSize = rect.sizeDelta;
        float t = 0;

        while (t < 1)
        {
            rect.sizeDelta = Vector2.Lerp(startSize, endSize, t);
            t += Time.deltaTime / animation_duration;
            yield return null;
        }

        yield return endAction;
    }

    public static IEnumerator MoveToPos(Transform transform, Vector3 endPos, float animation_duration,
        IEnumerator endAction = null)
    {
        var startpos = transform.position;
        float t = 0;
        while (t < 1)
        {
            transform.position = Vector3.Lerp(startpos, endPos, t);
            t += Time.deltaTime / animation_duration;
            yield return null;
        }

        yield return endAction;
    }
}