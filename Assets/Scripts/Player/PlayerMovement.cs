using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] private float speed;
    private Vector3 moveDir;



    // Start is called before the first frame update
    void Start()
    {
        Inputs.Init(this);
        Inputs.GameMode();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * moveDir;
    }
    public void SetMovementDirection(Vector3 direction)
    {
        moveDir = direction;
    }

}
