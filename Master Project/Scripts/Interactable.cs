using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	public bool inRangeOfPlayer;
	public bool interactedWith;
	public bool triggered;
	public GameObject alertBubble;
	
    // Start is called before the first frame update
    void Start()
    {
        inRangeOfPlayer = false;
		interactedWith = false;
		triggered = false;
    }
	
	public void OnTriggerEnter2D(Collider2D c){
		triggered = true;
	}
	
	public void OnTriggerExit2D(Collider2D c){
		triggered = false;
	}

    // Update is called once per frame
    void Update()
    {
        if(triggered){
			alertBubble.SetActive(true);
		}else{
			alertBubble.SetActive(false);
		}
    }
	
}
