using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Controls the generation and dynamic length of a rope
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// Script based on https://www.youtube.com/watch?v=dx3jb4muLjQ&t=0s
/// TODO if needed: update code to work based on object pooling for better performance
/// </remarks>
public class Rope : MonoBehaviour
{
    [SerializeField] GameObject hook;
    [SerializeField] GameObject ropeSegment;
    [SerializeField] int numberOfSegments = 10;

    Rigidbody2D prevSegment;
    ArrayList segments = new ArrayList();



    /// <summary>
    /// Initializes the rope
    /// </summary>
    void Start(){
        prevSegment = hook.GetComponent<Rigidbody2D>();
        GenerateRope();
    }
    /// <summary>
    /// Generates the rope
    /// </summary>
    void GenerateRope(){
        for(int i = 0; i < numberOfSegments; i++){
            AddSegment();
        }
    }
    /// <summary>
    /// Adds a new rope segment to the rope
    /// </summary>
    void AddSegment(){
        GameObject newSegment = CreateSegment();
        ConnectSegment(newSegment);
        UpdateRope(newSegment);
    }
    /// <summary>
    /// Helper function to create and position a new segment object
    /// </summary>
    /// <returns>
    /// Reference to the new segment object
    /// </returns>
    GameObject CreateSegment(){
        GameObject newSegment = Instantiate(ropeSegment);
        newSegment.transform.parent = transform;
        newSegment.transform.position = transform.position;
        return newSegment;
    }
    /// <summary>
    /// Helper function to link the new segment object to the rope
    /// </summary>
    /// <param name="newSegment"></param>
    void ConnectSegment(GameObject newSegment){
        if(prevSegment != hook.GetComponent<Rigidbody2D>()){
            newSegment.GetComponent<RopeSegment>().SetAbove(prevSegment.gameObject);
            prevSegment.GetComponent<RopeSegment>().SetBelow(newSegment);

            float spriteBottom = prevSegment.GetComponent<SpriteRenderer>().bounds.size.y;
            newSegment.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0, spriteBottom * -1);
        } else {
            newSegment.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0, 0);
        }
    }
    /// <summary>
    /// Helper function to update the ArrayList of segments and the previous segment global variable
    /// </summary>
    /// <param name="newSegment"></param>
    void UpdateRope(GameObject newSegment){
        newSegment.GetComponent<HingeJoint2D>().connectedBody = prevSegment;
        prevSegment = newSegment.GetComponent<Rigidbody2D>();
        segments.Add(newSegment);
    }
    /// <summary>
    /// Removes the last segment from the rope
    /// </summary>
    void RemoveSegment(){
        GameObject tempSegment = (GameObject) segments[segments.Count - 1];
        segments.Remove(tempSegment);
        Destroy(tempSegment);
    }
    /// <summary>
    /// Getter for the ArrayList of segments
    /// </summary>
    /// <returns>
    /// The segments ArrayList
    /// </returns>
    public ArrayList GetSegments(){
        return segments;
    }
    /// <summary>
    /// Gets the segment at the specified index in the segments ArrayList
    /// </summary>
    /// <param name="index"></param>
    /// <returns>
    /// The individual segment at the given index
    /// </returns>
    public GameObject GetSegment(int index){
        return (GameObject) segments[index];
    }
}
