using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the interaction between the player and a ship part.
/// </summary>
/// <remarks>
/// Authors: Gavin Levis
/// Date: November 28, 2023
/// </remarks>
public class GrabShipPart : MonoBehaviour
{

    [SerializeField] PlayerSettings settings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("ShipPart"))
        {
            Debug.Log("Gathered part");
            settings.partsCollected = settings.partsCollected + 1;
            Destroy(other.gameObject);
        }
    }
}
