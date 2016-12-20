using UnityEngine;
using System.Collections;

public class shootSpore : MonoBehaviour {

	public GameObject theProjectile;
	public float shootTime;
	public int chanceShoot;
	public Transform shootFrom;

	float nextShootTime;
	Animator canonAnim;

	// Use this for initialization
	void Start () {

		canonAnim = GetComponentInChildren<Animator> ();
		nextShootTime = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player" && nextShootTime < Time.time) {
			nextShootTime = Time.time + shootTime;
			if (Random.Range (0, 10) >= chanceShoot) {
				Instantiate (theProjectile, shootFrom.position, Quaternion.identity);
				canonAnim.SetTrigger("canonShoot");
			}
		}
	}
}
