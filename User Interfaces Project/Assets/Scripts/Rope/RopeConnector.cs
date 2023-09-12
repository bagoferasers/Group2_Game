using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Component script which allows an object to be attached to a rope
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// Script based on https://www.youtube.com/watch?v=olEC8mSezjk&t=367s&ab_channel=juul1a
/// TODO: Fix bug where dettaching from a rope can cause a desync between touching flag, OnTriggerExit event, and last touched ropeSegment; which can teleport the player unexpectedly
/// </remarks>
public class RopeConnector : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    [SerializeField] HingeJoint2D joint;

    bool isAttached = false;
    bool touching = false;

    Transform rope = null;
    GameObject ropeSegment = null;

    const float DETTACH_DELAY_TIME = .5f;



    /// <summary>
    /// Attaches the player to the rope segment they are touching
    /// </summary>
    /// <returns>
    /// A boolean value representing whether the player was attached or not
    /// </returns>
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
    /// <summary>
    /// Dettaches the player from the rope segment they are touching
    /// </summary>
    /// <returns>
    /// A boolean value representing whether the player was dettached or not
    /// </returns>
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
    /// <summary>
    /// Delays the detachment by a small amount of time
    /// This was done to prevent certain bugs, but may be unecessary
    /// </summary>
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



    /// <summary>
    /// Moves the player up 1 rope segment
    /// </summary>
    public void Ascend(){
        GameObject newSegment = joint.connectedBody.gameObject.GetComponent<RopeSegment>().GetAbove();
        ChangeConnection(newSegment);
    }
    /// <summary>
    /// Moves the player down 1 rope segment
    /// </summary>
    public void Descend(){
        GameObject newSegment = joint.connectedBody.gameObject.GetComponent<RopeSegment>().GetBelow();
        ChangeConnection(newSegment);
    }
    /// <summary>
    /// Helper function to move the player to a new rope segment
    /// </summary>
    /// <param name="newSegment"></param>
    void ChangeConnection(GameObject newSegment){
        if(newSegment != null){
            transform.position = newSegment.transform.position;
            joint.connectedBody = newSegment.GetComponent<Rigidbody2D>();
        }
    }



    /// <summary>
    /// Checks for collision with a rope trigger hitbox
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Rope"){
            ropeSegment = other.gameObject;
            touching = true;
        }
    }
    /// <summary>
    /// Checks for collision with a rope trigger hitbox ending
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Rope"){
            touching = false;
        }
    }



    /// <summary>
    /// Getter for the isAttached flag
    /// </summary>
    /// <returns>
    /// A boolean value representing whether the player is attached to a rope or not
    /// </returns>
    public bool GetIsAttached(){
        return isAttached;
    }
}
