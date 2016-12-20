using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {

	public float enemyMaxHealth;

	public GameObject enemyDeathFX;

	public bool drops;
	public GameObject theDrop;

	float currentHealth;

	// Use this for initialization
	void Start () {

		currentHealth=enemyMaxHealth;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addDamage(float damage){
		currentHealth -= damage;
		if(currentHealth<=0) makeDead();
	}

	void makeDead(){
		Destroy(gameObject.transform.transform.parent.gameObject);
		Instantiate (enemyDeathFX, transform.position, transform.rotation);
		if (drops)
			Instantiate (theDrop, transform.position, transform.rotation);
	}
}
