using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_s : MonoBehaviour
{
    public  Image HealthBarImage;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setFill(float value)
    {
        HealthBarImage.fillAmount = value;
    }


}
