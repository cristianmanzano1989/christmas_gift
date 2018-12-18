using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientosanta : MonoBehaviour {


    private Rigidbody2D rigiBody = null;
    private Animator anim = null;
    public float speed =7.0f;
    public float speddjump = 3.0f;

	// Use this for initialization
	void Start () {

        rigiBody = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        rigiBody.velocity = new Vector2(h * speed,rigiBody.velocity.y);
        anim.SetFloat("Horizontal", Mathf.Abs(h));
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigiBody.velocity = new Vector2(h*speed, 2*speddjump);
            anim.SetTrigger("jump");

        }
	}
}
