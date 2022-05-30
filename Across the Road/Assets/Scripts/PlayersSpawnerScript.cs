using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersSpawnerScript : MonoBehaviour
{
    public int SbNum;
    public int nSbNum;
    public int playerNum;
    public Transform[] SbLoc;
    public Transform[] reversebLoc;
    public GameObject[] Player;
    private float timer;
    public float ReSpawnTime = 5f;
    public float TimeInterval;
    public float DestroyTime;
   
    public GameObject[] realPlayer;
    public GameObject[] reversePlayer;
    public int Num;
    public int sNum;
   

    void Start()
    {
        //playerCheck = GameObject.FindWithTag("Player");
       
        SpawnReal();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;

        if (timer >= ReSpawnTime)
        {
            //Spawn();
            //SpawnReal();
            
            
            //Spawn();
            ReSpawnTime += TimeInterval;
            DestroyTime += TimeInterval;
        }
        
    }

    void Spawn()
    {
        SbNum = Random.Range(0, SbLoc.Length);
        playerNum = Random.Range(0, Player.Length);

        Instantiate(Player[playerNum], SbLoc[SbNum].position, transform.rotation);
    }
    void rSpawn()
    {
        nSbNum = Random.Range(0, reversebLoc.Length);
        playerNum = Random.Range(0, Player.Length);

        Instantiate(Player[playerNum], reversebLoc[nSbNum].position, transform.rotation);
    }

    public void SpawnReal()
    {
        SbNum = Random.Range(0, SbLoc.Length);
        Num = Random.Range(0, realPlayer.Length);
        Instantiate(realPlayer[Num], SbLoc[SbNum].position, transform.rotation);
    }
    public void SpawnReverse()
    {
        nSbNum = Random.Range(0, reversebLoc.Length);
        sNum = Random.Range(0, reversePlayer.Length);
        Instantiate(reversePlayer[sNum], reversebLoc[nSbNum].position, transform.rotation);
    }
    
}
