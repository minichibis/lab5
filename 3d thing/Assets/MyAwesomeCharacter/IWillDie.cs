/** Sam Carpenter
* these 2 things
* enemies will take damage
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWillDie : MonoBehaviour
{
	public float health = 50f;
	public float max = 50f;
    // Start is called before the first frame update
    void Start()
    {
        health = max;
    }

    public void damaged(float dmg){
		health -= dmg;
		if(health <= 0) die();
	}
	
	public void die(){
		Destroy(gameObject);
	}
}
