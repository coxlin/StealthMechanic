using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIndexUI : MonoBehaviour
{
    [SerializeField]
    private LightIndex _lightIndex;

    [SerializeField]
    private UnityEngine.UI.Text _text;

    private void Update()
    {
        _text.text = string.Format("Light Index: {0}", _lightIndex.Current.ToString("n2"));
    }
}
