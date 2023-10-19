using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private GameObject candyTouched;
    

       [SerializeField] private GameManager manager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
         candyTouched = collision.gameObject;

        manager.ObjectDestroyed();
        manager.AddScore(candyTouched.GetComponent<Collectible>().points);
        candyTouched.GetComponent<Collectible>().touched();
    }
}
