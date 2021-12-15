using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{
    public bool canMove;
    public bool moveNow;
    public int NumberOfStepsToMove;

    public PathobjectParent pathsParent;

    private void Awake()
    {
        pathsParent = FindObjectOfType<PathobjectParent>();
    }



}
