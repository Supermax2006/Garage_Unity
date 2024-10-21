using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] GameObject _object;
    [SerializeField] GameObject _finish;
    [SerializeField] Transform _finishTarget;
    [SerializeField] Transform _target;
    void Update()
    {
        if (_object.activeSelf == true)
        {
            transform.position = _target.position;
        }
        if (_finish.activeSelf == true) 
        {
            transform.position = _finishTarget.position;
        }

    }
}
