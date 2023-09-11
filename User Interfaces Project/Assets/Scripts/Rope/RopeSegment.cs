using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeSegment : MonoBehaviour
{   
    [SerializeField] GameObject above;
    [SerializeField] GameObject below;



    public GameObject GetAbove(){
        return above;
    }

    public void SetAbove(GameObject above){
        this.above = above;
    }

    public GameObject GetBelow(){
        return below;
    }

    public void SetBelow(GameObject below){
        this.below = below;
    }
}
