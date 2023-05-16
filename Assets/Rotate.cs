using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

   [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
