using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
	GameObject rotor;
	bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;

	// Use this for initialization
	void Start()
	{
		rotor = GameObject.FindWithTag("Rotor");
	}

	// Update is called once per frame
	void Update()
	{
		if (carrying)
		{
			carry(carriedObject);
			checkDrop();
		}
	}

	void carry(GameObject o)
	{
		Vector3 q = new Vector3(0f, -1f, 0f);
		o.transform.position = Vector3.Lerp(o.transform.position, rotor.transform.position  + q + rotor.transform.forward * distance, Time.deltaTime * smooth);
		o.transform.rotation = Quaternion.identity;
	}

	void OnTriggerStay(Collider collision)
    {
		pickup(collision);
    }

	void pickup(Collider collision)
	{
		
		if (Input.GetKeyDown(KeyCode.E))
		{
			//int x = Screen.width / 2;
			//int y = Screen.height / 2;

			//Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
			//RaycastHit hit;
			//if (Physics.Raycast(ray, out hit))

			Pickupable p = collision.GetComponent<Pickupable>();
			if (p != null)
			{
				carrying = true;
				carriedObject = p.gameObject;
				//p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
				p.gameObject.GetComponent<Rigidbody>().useGravity = false;
			}
		
		}
	}

	void checkDrop()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			dropObject();
		}
	}

	void dropObject()
	{
		carrying = false;
		//carriedObject.gameObject.rigidbody.isKinematic = false;
		carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
	}
}