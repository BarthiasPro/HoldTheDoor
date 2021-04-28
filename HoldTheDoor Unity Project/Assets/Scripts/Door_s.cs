using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Door_s : MonoBehaviour
{
    public float  hp = 10.0f;
    public GameObject HealthBar;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Repair()
    {
        hp += 3.0f;
        if(hp>10.0f)
        {
            hp = 10.0f;
        }
        UpdateUI_Door();

    }

    public void Damage()
    {
        hp -= 1.0f;
        if(hp <= 0)
        {
            Debug.Log("Loose");
            Destroy(this.gameObject);
            Destroy(HealthBar);
            Time.timeScale = 0;
        }
        UpdateUI_Door();
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.tag);
    }

    public void UpdateUI_Door()
    {
        HealthBar.GetComponent<HealthBar_s>().setFill(hp/10);
    }
}
