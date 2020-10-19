/** Sam Carpenter
* these 2 things
* https://wiki.teamfortress.com/w/images/4/4a/Heavy_domination16.wav
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingYou : MonoBehaviour
{
	public float damage = 10f;
	public float range = 100f;
	public float punch = 10f;
	public Camera cam;
	public ParticleSystem flash;
    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("Fire1")) { 
			flash.Play();
			dakka();
		}
    }
	
	void dakka(){
		RaycastHit hitInfo;
		if ( Physics.Raycast(cam.transform.position,cam.transform.forward, out hitInfo, range) )
		{
			IWillDie ill = hitInfo.transform.gameObject.GetComponent<IWillDie>();
			if (ill != null){
				ill.damaged(damage);
				if (ill.GetComponent<Rigidbody>() != null){
					ill.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * punch, ForceMode.Impulse);
				}
			}
		}
	}
}