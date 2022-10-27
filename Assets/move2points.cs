using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2points : MonoBehaviour
{
    public Transform pointBT;
    public float speed;

    IEnumerator Start()
    {
        Vector3 pointB = pointBT.position;
        Vector3 pointA = transform.position;
        while (true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 3));
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        float i = 0.0f;
        float rate = speed / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }

}
