using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Tower_s : MonoBehaviour
{
    public int ammo = 10;
    public GameObject Canon;
    public GameObject Canon_Inside;
    public GameObject Bullet;
    public GameObject AmmoBar;
    public ParticleSystem Shooting_Effect;
    public float timeStamp = 0.0f;
    public float coolDown = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        ammo--;
        UpdateUI_Tower();
        timeStamp = Time.time + coolDown;
        Shooting_Effect.Play();
    }

    public void Reload()
    {
        ammo += 3;
        if(ammo > 10)
        {
            ammo = 10;
        }
        UpdateUI_Tower();
    }

    public void UpdateUI_Tower()
    {
        AmmoBar.GetComponent<AmmoBar_s>().setFill((float)ammo / 10);
    }

    private void OnTriggerStay(Collider col)
    {
        //Debug.Log(col.gameObject.tag);
        if(col.gameObject.tag == "Enemy")
        {
            if(ammo > 0 && timeStamp <= Time.time )
            {
                Canon.transform.LookAt(col.gameObject.transform);
                Instantiate(Bullet, Canon_Inside.transform.position, Canon.transform.rotation);
                Shoot();
            } 
        }
    }

}
