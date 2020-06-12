using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 2f;

    public Transform rotor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = rotor.transform.right * x + rotor.transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

}
