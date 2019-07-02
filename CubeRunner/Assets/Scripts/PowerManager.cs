using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour {

 //   public GameObject player;
    public GameObject thin;
    public GameObject invincible;
    public GameObject boost;
    public GameObject slowDown;
    public float spawnTime = 10f;
    public Transform[] invincibleSpawnPoints;
    public Transform[] thinSpawnPoints;
    public Transform[] boostSpawnPoints;
    public Transform[] slowDownSpawnPoints;
  /*  public void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    } */
    private void Start()
    {
       InvokeRepeating("SpawnInvincible", spawnTime, spawnTime);
       InvokeRepeating("SpawnThin", spawnTime, spawnTime);
       InvokeRepeating("SpawnBoost", spawnTime, spawnTime);
        InvokeRepeating("SpawnSlowDown", spawnTime, spawnTime);
    }

    public void SpawnInvincible(){
        int spawnPointIndex = Random.Range(0, invincibleSpawnPoints.Length);
        Instantiate(invincible, invincibleSpawnPoints[spawnPointIndex].position, invincibleSpawnPoints[spawnPointIndex].rotation);
    }
    public void SpawnThin(){
        int spawnPointIndex = Random.Range(0, thinSpawnPoints.Length);
        Instantiate(thin, thinSpawnPoints[spawnPointIndex].position,thinSpawnPoints [spawnPointIndex].rotation);
    }
    public void SpawnBoost(){
        int spawnPointIndex = Random.Range(0, boostSpawnPoints.Length);
        Instantiate(boost, boostSpawnPoints[spawnPointIndex].position, boostSpawnPoints[spawnPointIndex].rotation);
    }
    public void SpawnSlowDown(){
        int spawnPointIndex = Random.Range(0, slowDownSpawnPoints.Length);
        Instantiate(slowDown, slowDownSpawnPoints[spawnPointIndex].position, slowDownSpawnPoints[spawnPointIndex].rotation);

    }
}
