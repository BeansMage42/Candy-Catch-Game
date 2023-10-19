using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject candyTouched;
    [SerializeField] private GameManager manager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        candyTouched = collision.gameObject;

        manager.ObjectDestroyed();
        candyTouched.GetComponent<Collectible>().touched();
    }
}
