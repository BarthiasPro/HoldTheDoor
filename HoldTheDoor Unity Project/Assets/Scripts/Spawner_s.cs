using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_s : MonoBehaviour
{
    public GameObject enemy_Prefab;
    public bool game_on = false;
    public float spawner_rate = 1.0f;
    public float nextSpawn = 0.0f;
    
     
        
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nextSpawn <= Time.time)
        {
            Spawn();
            nextSpawn = Time.time + spawner_rate;
            
        }
    }

    public void Spawn()
    {
        Vector3 position = new Vector3(Random.Range(-2.5f, 2.5f), 0, Random.Range(40.0f, 60.0f));
        Instantiate(enemy_Prefab, position, Quaternion.identity);
    }
}
