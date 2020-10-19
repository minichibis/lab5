/** Sam Carpenter
* these 2 things
* making new outdated code
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseyLookie : MonoBehaviour
{
	public float sensitivity = 100f;
	public GameObject player;
	private float vertlookrot = 0f;
    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
		float mousey = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
		
		player.transform.Rotate(Vector3.up * mousex);
		
		vertlookrot -= mousey;
		vertlookrot = Mathf.Clamp(vertlookrot, -90f, 90f);
		//no idea what a quaternion even is but if it works more power to it
		transform.localRotation = Quaternion.Euler(vertlookrot, 0f, 0f);
    }
	
	//were evil
	private void OnApplicationFocus(bool focus){
		Cursor.lockState = CursorLockMode.Locked;
	}
}
