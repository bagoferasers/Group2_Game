using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script based on https://www.youtube.com/watch?v=olEC8mSezjk&t=367s&ab_channel=juul1a
//TODO: Fix bug where dettaching from a rope can cause a desync between touching flag, OnTriggerExit event, and last touched ropeSegment; which can teleport the player unexpectedly
public class RopeConnector : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [SerializeField] HingeJoint2D joint;

    bool isAttached = false;
    bool touching = false;

    Transform rope = null;
    GameObject ropeSegment = null;

    const float DETTACH_DELAY_TIME = .5f;



    public bool Attach(){
        if(!touching || isAttached){
            return false;
        }

        joint.connectedBody = ropeSegment.transform.parent.GetComponent<Rigidbody2D>();
        joint.enabled = true;
        isAttached = true;
        rope = ropeSegment.transform.parent;

        return true;
    }

    public bool Dettach(){
        if(!isAttached){
            return false;
        }

        joint.enabled = false;
        isAttached = false;
        touching = true;
        DelayedDettach();

        return true;
    }

    void DelayedDettach(){
        StartCoroutine(DelayedDettachRoutine());

        IEnumerator DelayedDettachRoutine(){
            yield return new WaitForSeconds(DETTACH_DELAY_TIME);
            //These lines will fix the afformentioned bug, but then the player cannot re-attached to the rope without moving away first
            //joint.connectedBody = null;
            //ropeSegment = null;
            rope = null;
        }
    }



    public void Ascend(){
        GameObject newSegment = joint.connectedBody.gameObject.GetComponent<RopeSegment>().GetAbove();
        ChangeConnection(newSegment);
    }

    public void Descend(){
        GameObject newSegment = joint.connectedBody.gameObject.GetComponent<RopeSegment>().GetBelow();
        ChangeConnection(newSegment);
    }

    void ChangeConnection(GameObject newSegment){
        if(newSegment != null){
            transform.position = newSegment.transform.position;
            joint.connectedBody = newSegment.GetComponent<Rigidbody2D>();
        }
    }



    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Rope"){
            ropeSegment = other.gameObject;
            touching = true;
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Rope"){
            touching = false;
        }
    }



    public bool GetIsAttached(){
        return isAttached;
    }
}
