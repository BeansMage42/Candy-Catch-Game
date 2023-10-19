using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inputs 
{
    private static PlayerControls _controls;

    public static void Init(PlayerMovement myPlayer)
    {

        _controls = new PlayerControls();

        _controls.GameMode.Movement.performed += ctx =>
        {
            myPlayer.SetMovementDirection(ctx.ReadValue<Vector3>());
        };


    }
    public static void GameMode()
    {
        _controls.GameMode.Enable();
    }
    public static void MenuMode()
    {
        _controls.GameMode.Disable();
    }
}
