using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public struct Triangle
{

}

public struct TreeSplitCollisionBox
{

}


public class CuttableTreeScript : MonoBehaviour
{

    private void Start()
    {
        
    }

    public void CutAt(Vector3 position, Vector3 normal)
    {
        
        //check effected Collision Boxes

        //store collision boxes below splitting plane 

        //store collision boxes above splitting plane 


        //for each effected collision box

            //create new collision box for the new mesh bellow the splitting plane

            //create new collision box for the new mesh above the splitting plane
            
            //for each triangle inside collisionBox

                //if triangle is split

                    //if its face neighbor is not effected by the cut

                        //get intersection points of triangle and plane

                        //create new bottomSplitTriangle

                         //create new upperSplitTriangle

                    //if its neighbor is effected by the cut

                        //get intersection points of triangle and face

                        //
                    
                   


                

                



    }
}
