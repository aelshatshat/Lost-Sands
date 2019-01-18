using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealthManager : MonoBehaviour {
    public int playerMaxHealth;
    public int playerCurrentHealth;
    private float waitTimer = 3;
    private float waitTimerCounter = 3;
	// Use this for initialization
	void Start () {
        playerCurrentHealth = playerMaxHealth;

	}
	
	// Update is called once per frame
	void Update () {
		if(playerCurrentHealth <= 0)
        {

           
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            waitTimerCounter -= Time.deltaTime;
            if (waitTimerCounter <= 0)
            {
                gameObject.SetActive(true);
                playerCurrentHealth = playerMaxHealth;
                waitTimerCounter = waitTimer;
            }
        }
        if(playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
	}

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
}
