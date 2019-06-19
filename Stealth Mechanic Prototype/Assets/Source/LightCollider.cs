using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    private LightIndex _lightIndex;

    [SerializeField]
    private CapsuleCollider _collider;

    private void OnTriggerStay(Collider other)
    {
        if (_lightIndex == null)
        {
            _lightIndex = other.GetComponent<LightIndex>();
        }
        float pointCount = 0f;
        for (int i = 0; i < _lightIndex.TransformsToCheck.Length; ++i)
        {
            var point = _lightIndex.TransformsToCheck[i].position;
            float dist = Vector3.Distance(transform.position, point);
            if (dist <= _collider.radius)
            {
                pointCount++;
            }
        }
        //Debug.Log("PointCount:" + pointCount);
        float indexAmnt = pointCount / _lightIndex.TransformsToCheck.Length;
        Debug.Log(indexAmnt);
        _lightIndex.SetIndex(indexAmnt);
    }

    private void OnTriggerExit(Collider other)
    {
        _lightIndex.SetIndex(0f);
        _lightIndex = null;
    }
}
