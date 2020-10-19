/** Sam Carpenter
* these 2 things
* makes the cylinger go vroom
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movinging : MonoBehaviour
{
	public CharacterController cont;
	public float speed = 12f;
	
	public Vector3 velocity;
	public float defaultgrav = -9.81f;
	public float gravity = -9.81f * 2f;
	public float gravmult = 2f;
	
	public bool grounded = true;
	public Transform groundchecker;
	public float grounddist = 0.4f;
	public LayerMask gmask;
	
	public float jheight = 1.8f;
	public Text win;
	public bool winned = false;
	
	void Awake(){
		gravity = defaultgrav * gravmult;
	}
	
	void Start(){
		win.enabled = false;
		winned = false;
	}
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		
		Vector3 move = (transform.right * x) + (transform.forward * z);
		cont.Move(move * speed * Time.deltaTime);
		
		grounded = Physics.CheckSphere(groundchecker.position, grounddist, gmask);
		if (Input.GetButtonDown("Jump") && grounded){
			velocity.y = Mathf.Sqrt(jheight * -2f * gravity);
		}
		if(grounded && velocity.y < 0){
			velocity.y = -2f;
		} else{
			velocity.y += gravity * Time.deltaTime;
			cont.Move(velocity * Time.deltaTime);
		}
	}
	
	 private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
			win.enabled = true;
			winned = true;
		}	
	}
}
