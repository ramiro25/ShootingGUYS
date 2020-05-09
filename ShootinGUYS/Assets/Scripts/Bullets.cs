using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    //Sets the speed of the bullets
    public float speed = 10f;

    void Update()
    {
        //Shoots the Projectiles to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        BulletsOutScreen();
    }

    private void BulletsOutScreen()
    {
        //GameObject is destroyed when get out of the screen
        if(transform.position.x > 10)
        {
            Destroy(this.gameObject);
        }
    }

}
