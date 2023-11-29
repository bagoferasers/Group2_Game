using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSound : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public List<AudioClip> songs = new List<AudioClip>();

    private bool inIdle = true;
    private bool inChase = false;
    private bool inLowHealth = false;

    public float chaseDistance = 1;

    void Start()
    {
        AudioController.PlayMusic(gameObject, songs[0]);
    }

    void Update()
    {
        if(Vector3.Distance(enemy.transform.position, player.transform.position) > chaseDistance && !inIdle)
        {
            Debug.Log("Idle...");
            inIdle = true;
            inChase = false;
            inLowHealth = false;
            AudioController.PlayMusic(gameObject, songs[0]);
        }
        if (Vector3.Distance(enemy.transform.position, player.transform.position) <= chaseDistance && !inChase)
        {
            Debug.Log("Chase...");
            inIdle = false;
            inChase = true;
            inLowHealth = false;
            AudioController.PlayMusic(gameObject, songs[1]);
        }
    }
}
