using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUp : MonoBehaviour
{
    [SerializeField] GameObject _move;
    [SerializeField] GameObject _door;
    [SerializeField] double sec = 0;
    void Update()
    {
        if (_move.activeSelf == true)
        {
            transform.position += transform.up * Time.deltaTime * 1f;
            sec += Time.deltaTime;
        }
        if (sec >= 3)
        {
            _door.SetActive(false);
        }
    }
}
