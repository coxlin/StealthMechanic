using System.Collections;
using System.Collections.ObjectModel;
using UnityEngine;

public class LightIndex : MonoBehaviour
{
    [SerializeField]
    private Transform[] _transformsToCheck;
    public Transform[] TransformsToCheck => _transformsToCheck;

    public float Current { private set; get; } = 0f;

    public void SetIndex(float amount)
    {
        Current = amount;
    }


}
