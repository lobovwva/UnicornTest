using UnityEngine;

public class Spawner : MonoBehaviour // скрипт рандомного спавнера врагов в спавн поинтах через определенное время
{
    public GameObject[] enemy; 
    public GameObject[] spawnpos; 

    private int rand;
    private int randPosition;
    public float StartTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = StartTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, enemy.Length);
            randPosition = Random.Range(0, spawnpos.Length);
            Instantiate(enemy[rand], spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = StartTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
