using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script based on https://www.youtube.com/watch?v=dx3jb4muLjQ&t=0s
//TODO if needed: update code to work based on object pooling for better performance
public class Rope : MonoBehaviour
{
    [SerializeField] GameObject hook;
    [SerializeField] GameObject ropeSegment;
    [SerializeField] int numberOfSegments = 10;

    Rigidbody2D prevSegment;
    ArrayList segments = new ArrayList();



    void Start(){
        prevSegment = hook.GetComponent<Rigidbody2D>();
        GenerateRope();
    }

    void GenerateRope(){
        for(int i = 0; i < numberOfSegments; i++){
            AddSegment();
        }
    }

    void AddSegment(){
        GameObject newSegment = CreateSegment();
        ConnectSegment(newSegment);
        UpdateRope(newSegment);
    }

    GameObject CreateSegment(){
        GameObject newSegment = Instantiate(ropeSegment);
        newSegment.transform.parent = transform;
        newSegment.transform.position = transform.position;
        return newSegment;
    }

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

    void UpdateRope(GameObject newSegment){
        newSegment.GetComponent<HingeJoint2D>().connectedBody = prevSegment;
        prevSegment = newSegment.GetComponent<Rigidbody2D>();
        segments.Add(newSegment);
    }

    void RemoveSegment(){
        GameObject tempSegment = (GameObject) segments[segments.Count - 1];
        segments.Remove(tempSegment);
        Destroy(tempSegment);
    }

    public ArrayList GetSegments(){
        return segments;
    }

    public GameObject GetSegment(int index){
        return (GameObject) segments[index];
    }
}
