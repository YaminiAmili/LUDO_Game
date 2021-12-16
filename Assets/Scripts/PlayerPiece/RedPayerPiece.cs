using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPayerPiece : PlayerPiece
{

    private void OnMouseDown()
    {
        canMove = true;
        MoveSteps();
        //StartCoroutine("MoveStepsEnum");
    }


   
    
}
