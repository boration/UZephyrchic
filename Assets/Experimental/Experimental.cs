using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Experimental : MonoBehaviour
{

    [SerializeField] private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //test 1
    }

    // Update is called once per frame
    void Update()
    {
        float deltaSpeed = speed * Time.deltaTime;
        transform.Rotate(deltaSpeed,deltaSpeed,deltaSpeed);
    }
}
