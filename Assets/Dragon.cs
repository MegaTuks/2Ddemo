using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dragon : MonoBehaviour {

	public float speed = 10f;
	public float jump = 450f;
	public SpriteRenderer wyvern;

	public Rigidbody2D rb2d;
	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void FixedUpdate() 
	{
		float x  = Input.GetAxis ("Horizontal");
		if(x > 0) {
		 wyvern.flipX = true;

		} else if  (x < 0) {
			wyvern.flipX = false;
		} else if (x == 0) {
			wyvern.flipX = wyvern.flipX;
		}
		Debug.Log (x);
		float y  = Input.GetAxis ("Vertical");
		//rb2d.AddForce((Vector2.up * jump)* y);
		rb2d.AddForce ( (Vector2.right * speed) * x);
	}
}
