using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;


    public void EndGame()
    {
        if (gameHasEnded)
        {
            return;
        }

        rotator.enabled = false;
        spawner.enabled = false;
        gameHasEnded = true;

    }
}
