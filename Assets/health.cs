using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{

    public Slider healthSlider;
    public Text healthText;
    public int rate = 1;
    public float maxHealth = 5;
    public float minHealth = 0;
    
    // Start is called before the first frame update
    public void Start()
    {
        healthSlider = gameObject.GetComponent("Slider") as Slider;
        healthText = GameObject.Find("Text").GetComponent<Text>();
        healthSlider.minValue = minHealth;
        healthSlider.maxValue = maxHealth;
        setHealth(getMaxHealth());
        updateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void updateText()
    {
    	int pLoss = (int) Math.Round((1-(getHealth() / getMaxHealth()))*100);
    	healthText.text = "Packet Loss: "+pLoss+"%";
    }
    
    void setHealth(float health)
    {
    	healthSlider.value = health;
    	updateText();
    }
    
    float getHealth()
    {
    	return healthSlider.value;
    }
    
    float getMaxHealth()
    {
    	return healthSlider.maxValue;
    }
    
    void incHealth()
    {
    	if (getHealth()+rate < getMaxHealth())
    	    healthSlider.value = getHealth() + rate;
    	else
    	    healthSlider.value = getMaxHealth();
    	    
        updateText();
    }
    
    public void decHealth()
    {
    	if (getHealth()-rate > healthSlider.minValue)
    	    healthSlider.value = getHealth() - rate;
    	else
    	    healthSlider.value = healthSlider.minValue;
    	updateText();
    }
}

