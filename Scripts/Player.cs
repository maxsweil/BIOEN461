using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject triggering_NPC;
    private bool triggering;

    public GameObject NPC_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {
            NPC_text.SetActive(true);

        } else
        {
            NPC_text.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="NPC")
        {
            triggering = true;
            triggering_NPC = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag =="NPC")
        {
            triggering = false;
            triggering_NPC = null;
        }

    }
}
