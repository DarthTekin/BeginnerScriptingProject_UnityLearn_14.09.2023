using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction {North, South, East, West};

    // Start is called before the first frame update
    void Start()
    {
        Direction myDirection;
        myDirection = Direction.North;
    }

    Direction ReverseDirection(Direction dir)
    {
        if(dir == Direction.North)
        {
            dir = Direction.South;
        }
        if(dir == Direction.South)
        {
            dir = Direction.North;
        }
        if (dir == Direction.East)
        {
            dir = Direction.West;
        }
        if (dir == Direction.West)
        {
            dir = Direction.East;
        }

        return dir;
    }
}
