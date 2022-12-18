using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	private int maxHealth = 5;
	public int health;
	
	[SerializeField]public Image[] hearts;
    

    void Start()
    {
        health = maxHealth;
		UpdateHealth();
    }

	// https://www.youtube.com/watch?v=3dgsMgMCyUg 5:02
	public void UpdateHealth()
    {
		for (int i = 0; i < hearts.Length; i++)
        {
			if(i < health)
            {
				hearts[i].color = Color.white;
            }
			else
            {
				hearts[i].color = Color.black;
			}
        }
	}

	


}

