using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    private float vInput;
    private float hInput;

    

    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
    vInput = UnityEngine.Input.GetAxis("Vertical") * moveSpeed;
    hInput = UnityEngine.Input.GetAxis("Horizontal") * rotateSpeed;
    this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
    this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
}

  
}
