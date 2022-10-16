using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            //Destroy the player
            Destroy(gameObject);
            //Destroy the enemy
            Destroy(collision.gameObject);
        }
    }

    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
