using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Container class for rope segment links
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class RopeSegment : MonoBehaviour
{   
    [SerializeField] GameObject above;
    [SerializeField] GameObject below;



    /// <summary>
    /// Getter for the above connected segment
    /// </summary>
    /// <returns>
    /// The rope segment connected above
    /// </returns>
    public GameObject GetAbove(){
        return above;
    }
    /// <summary>
    /// Setter for the above connected segment
    /// </summary>
    /// <param name="above"></param>
    public void SetAbove(GameObject above){
        this.above = above;
    }
    /// <summary>
    /// Getter for the below connected segment
    /// </summary>
    /// <returns>
    /// The rope segment connected below
    /// </returns>
    public GameObject GetBelow(){
        return below;
    }
    /// <summary>
    /// Setter for the below connected segment
    /// </summary>
    /// <param name="below"></param>
    public void SetBelow(GameObject below){
        this.below = below;
    }
}
