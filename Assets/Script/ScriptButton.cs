using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptButton : MonoBehaviour
{
    public GameObject GirlPlayer;
    public float value; //use this to move
    public Vector3 sizeChange; //to change size

    public void MoveLeft()  //to move left 

    {
        value = value - 5f;
        GirlPlayer.transform.position = new Vector3(value,0, 0);


    }

    public void MoveRight()  //to move right

    {
        value = value + 5f;
        GirlPlayer.transform.position = new Vector3(value, 0, 0);


    }

    public void Rotate()   //rotatetoleft physically 
    {
       GirlPlayer.transform.Rotate(0f, 3f, 0f);
    }

    public void Grow()
    {
        GirlPlayer.transform.localScale = GirlPlayer.transform.localScale + sizeChange;
    }

    public void Reset()
    {
        GirlPlayer.transform.position = new Vector3(0f, 0f, 0f);  //reseting the position to old position of girlplayer
        GirlPlayer.transform.rotation = Quaternion.identity;
            //Euler(new Vector3(0, 0, 0));   //resetting the rotation 
        GirlPlayer.transform.localScale = new Vector3(4.5f, 4.5f, 4.5f); //
    }
}
  
    

   