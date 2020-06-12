using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayHappy : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    public Material matChange;
    public GameObject face;
    public Text speech;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Backpack"))
        {
            face.GetComponent<Renderer>().material = matChange;
            myAnimationController.SetBool("Happy", true);
            speech.text = "Thank you for helping me!";
            speech.alignment = TextAnchor.MiddleCenter;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Backpack"))
        {
            myAnimationController.SetBool("Happy", false);
        }
    }
}
