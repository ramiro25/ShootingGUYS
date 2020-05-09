﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] projectiles;

    public void CircleShoot() //Send projectil "0"
    {
        Instantiate(projectiles[0], transform.position, Quaternion.identity);
    }

    public void SquareShoot() //Send projectil "1"
    {
        Instantiate(projectiles[1], transform.position, Quaternion.identity);
    }

    public void TriangleShoot() //Send projectil "2"
    {
        Instantiate(projectiles[2], transform.position, Quaternion.identity);
    }

}
