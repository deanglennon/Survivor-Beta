using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
	[SerializeField] private int damage;
	[SerializeField] private Health _health;

 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Damage();
        }
    }

     // https://www.youtube.com/watch?v=3dgsMgMCyUg 8:02
    void Damage()
    {
        _health.health = _health.health - damage;
        _health.UpdateHealth();
        gameObject.SetActive(false);

   
            if (_health.health == 0)
            {
                SceneManager.LoadScene(sceneName: "Dead");
            }
        }
    }
