using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {

	public float fullHealth;
	public GameObject deathFX;
	public AudioClip playerHurt;

	public restartGame theGameManager;

	float currentHealth;
	playerController controlMovement;

	AudioSource playerAS;

	//HUD variables

	public Slider healthSlider;
	public Image damageScreen;
	public Text gameOverScreen;

	bool damaged = false;
	Color damagedColor = new Color(0f,0f,0f,1f);
	float smoothColor = 10f;



	// Use this for initialization
	void Start () {

		currentHealth = fullHealth;
		controlMovement = GetComponent<playerController> ();

		//HUD initialization
		healthSlider.maxValue = fullHealth;
		healthSlider.value = fullHealth;

		damaged = false;

		playerAS = GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (damaged) {

			damageScreen.color = damagedColor;

		} else {
			damageScreen.color = Color.Lerp (damageScreen.color, Color.clear, smoothColor * Time.deltaTime);
		}
		damaged = false;
	}

	public void addDamage(float damage){

		if (damage <= 0) return;
		currentHealth -= damage;

		playerAS.clip = playerHurt;
		playerAS.Play ();

		healthSlider.value = currentHealth;
		damaged = true;

		if (currentHealth <= 0) {
			makeDead();
		}
	}

	public void addHealth(float health){
		currentHealth += health;
		if (currentHealth > fullHealth) currentHealth=fullHealth;
		healthSlider.value = currentHealth;
	}

	public void makeDead(){
		Instantiate (deathFX, transform.position, transform.rotation);
		Destroy (gameObject);
		damageScreen.color = damagedColor;
		Animator gameOverAnimator = gameOverScreen.GetComponent<Animator> ();
		gameOverAnimator.SetTrigger ("gameOver");
		theGameManager.restartTheGame ();
	}

	public void winGame(){
		Destroy (gameObject);
		theGameManager.restartTheGame ();
	}
}
