using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    private LightIndex _lightIndex;

    [SerializeField]
    private Collider _collider;

    private void OnTriggerStay(Collider other)
    {
        if (_lightIndex == null)
        {
            _lightIndex = other.GetComponent<LightIndex>();
        }
        _lightIndex.SetIndex(1f);
        /*int pointCount = 0;
        for (int i = 0; i < _lightIndex.TransformsToCheck.Length; ++i)
        {
            var point = _lightIndex.TransformsToCheck[i].position;
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        _lightIndex.SetIndex(0f);
        _lightIndex = null;
    }
}
