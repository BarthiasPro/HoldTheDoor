using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet_s : MonoBehaviour
{
    public Rigidbody rig_bullet;
    public GameObject Score;
    public int moveSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        rig_bullet.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Score.GetComponent<Score_s>().IncrementScore();
            Destroy(other.transform.parent.gameObject);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Floor")
        {
            Debug.Log("ball on the floor");
            Destroy(this.gameObject);
        }
    }
}
