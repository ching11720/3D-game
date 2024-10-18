using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sweeperController : MonoBehaviour
{
    public float forceValue = 2f;
    Rigidbody2D rbody2D;

    void Start () {
        rbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Update () {
        Vector2 force2D = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            force2D.y += forceValue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValue;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValue;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValue;
        }
        rbody2D.AddForce(force2D);
    }
    public void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Garbage")) {
            Destroy(other.gameObject);
            GameObject.Find("GameManager").GetComponent<GameManager>().addScore(100);
        } 
        else if (other.CompareTag("Bomb")) {
            GameObject.Find("GameManager").GetComponent<GameManager>().EndGame();
        }
    }
}