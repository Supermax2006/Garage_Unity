using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMoove : MonoBehaviour
{
    [SerializeField] GameObject _walk;
    [SerializeField] GameObject _rotateLeft;
    [SerializeField] GameObject _rotateLow;
    [SerializeField] GameObject _rotateLower;
    [SerializeField] GameObject _rotateNormal;
    [SerializeField] GameObject _back;
    [SerializeField] GameObject _startPozition;
    [SerializeField] GameObject _startRotate;
    [SerializeField] Transform _zeroRotate;
    
    void Update()
    {

        if (_walk.activeSelf == true)
        {
            transform.position += transform.forward * Time.deltaTime * 1f;
        }
        else if (_walk.activeSelf == false)
        {
            transform.position += transform.forward * 0;
        }

        if (_back.activeSelf == true)
        {
            transform.position -= transform.forward * Time.deltaTime * 0.5f;
        }


        if (_rotateLeft.activeSelf == true)
        {
            transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0, 0, 0), 0.8f);
        }

        if (_rotateLow.activeSelf == true)
        {
            transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(15, 0, 0), 0.3f);
        }

        if (_rotateLower.activeSelf == true)
        {
            transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(30, 0, 0), 0.4f);
        }

        if (_rotateNormal.activeSelf == true)
        {
            transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0, 0, 0), 0.3f);
        }


        if (_startPozition.activeSelf == true)
        {
            transform.position = new Vector3(-27.27f, 0.003f, -15.66f);
            transform.rotation = _zeroRotate.rotation;
        }

        if (_startRotate.activeSelf == true)
        {
            transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0, 90, 0), 0.8f);
        }
    }
}
