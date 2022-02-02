using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
