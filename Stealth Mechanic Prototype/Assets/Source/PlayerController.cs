using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private CharacterController _characterController;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private GameObject _visuals;

    private void Awake()
    {
    }

    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
        Vector3 moveVec = new Vector3(xMove, 0f, yMove);
        if (Mathf.Abs(xMove) > 0.1f || Mathf.Abs(yMove) > 0.1f)
        {
            _visuals.transform.rotation = Quaternion.LookRotation(moveVec);
            _animator.CrossFade("Moving", 0f);
        }
        else
        {
            _animator.CrossFade("Idle", 0f);
        }

        _characterController.Move(moveVec * _speed * Time.deltaTime);
    }
}
