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
            var point = new Vector3(
                _lightIndex.TransformsToCheck[i].position.x,
                transform.position.y,
                _lightIndex.TransformsToCheck[i].position.z);

            float dist = Vector3.Distance(transform.position, point);
            if (dist <= _collider.radius)
            {
                pointCount++;
            }
        }
        float indexAmnt = pointCount / _lightIndex.TransformsToCheck.Length;
        _lightIndex.SetIndex(indexAmnt);
    }

    private void OnTriggerExit(Collider other)
    {
        _lightIndex.SetIndex(0f);
        _lightIndex = null;
    }
}
