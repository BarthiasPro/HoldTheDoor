using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody rig_enemy;
    public ParticleSystem Attack_Effect;

    public int  moveSpeed = 5;
    public float attack_rate = 1.0f;
    public float nextAttack = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        rig_enemy.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Door" && nextAttack <= Time.time)
        {
            other.gameObject.GetComponent<Door_s>().Damage();
            Attack_Effect.Play();
            nextAttack = Time.time + attack_rate;
        }
    }
}
