using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class rotatingWith : MonoBehaviour
{
    public Transform rotObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(this.transform.localEulerAngles.x, rotObj.transform.localEulerAngles.y, this.transform.localEulerAngles.z);

        this.transform.localEulerAngles = pos;
    }
}
