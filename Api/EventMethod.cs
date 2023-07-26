using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class EventMethod : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A)) 
        //{
        //    Debug.Log("A");
        //}
        //if (Input.GetMouseButtonDown(0)) Debug.Log("left");
        //if (Input.GetMouseButtonDown(1)) Debug.Log("right");
        //if (Input.GetMouseButtonDown(2)) Debug.Log("middle");
        //if (Input.GetKey(KeyCode.A)) Debug.Log("A");
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        if (Input.GetButtonDown("Fire1")) Debug.Log("fire1--mouse_left");

        if (Input.GetButtonDown("Fire2")) Debug.Log("fire2--mouse_right");

        if (Input.GetButtonDown("Fire3")) Debug.Log("fire3--mouse_middle");
    }
    //void Move() 
    //{
    //    float speed = 2.0f;
    //    float horizontal = Input.GetAxis("Horizontal");
    //    float vertical = Input.GetAxis("Vertical");
    //}
 }

