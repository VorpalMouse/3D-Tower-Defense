using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCollisionDetector : MonoBehaviour
{
    bool isInOtherTower=false;

    void Start()
    {
        isInOtherTower = false;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag.Equals("tower")||other.gameObject.tag.Equals("Path"))
        {
            isInOtherTower = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("tower") || other.gameObject.tag.Equals("Path"))
        {
            isInOtherTower = false;
        }
    }

    public bool getIsInOtherTower()
    {
        return isInOtherTower;
    }
}
