using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int points;

   
    public void touched()
    {

        Destroy(gameObject);
    }
}
