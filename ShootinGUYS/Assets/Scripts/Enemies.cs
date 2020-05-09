using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{    
    private float _speed;

    private void Start() 
    {
        _speed = 2.0f;
    }

    void Update()
    {
        //Enemies runs to the left
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        EnemiesOutScreen();
        SpeedUp();
    }

    private void EnemiesOutScreen()
    {
        if(transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }

    private void SpeedUp()
    {
        if (_speed >= 2f && _speed <= 20f) 
        {
            _speed += 0.15f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Enemy Vs Player = Both dies
        if(other.CompareTag("Player")) 
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        //Enemy Vs SameBullet = Both dies
        if(other.tag == gameObject.tag) 
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        //Enemy Vs OtherBullet = Bullet die
        else if(other.tag != gameObject.tag)
        {
            Destroy(other.gameObject);
        }
    }
}
