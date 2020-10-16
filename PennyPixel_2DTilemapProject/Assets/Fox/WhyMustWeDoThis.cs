/** Sam Carpenter
* these 2 things
* im just not bringing the same fire anymore im sorry
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WhyMustWeDoThis : MonoBehaviour
{
	public Text scoretxt;
	public Text wintext;
	public int score;
	public bool winned;
	
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
		wintext.enabled = false;
		winned = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoretxt.text = score.ToString();
    }
	
	void OnTriggerEnter2D(Collider2D c){
		if (c.CompareTag("Finish")) {
			winned = true;
			wintext.enabled = true;
		}
	}
}
