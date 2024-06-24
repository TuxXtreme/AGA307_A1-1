using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Target")
        {
            col.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            col.transform.localScale = Vector3.one * 1.1f;
            Destroy(GetComponent<MeshRenderer>());
            
            
        }
    }

    private void OnCollisionStay(Collision col)
    {
        if(col.collider.tag == "Target")
        {
           // col.transform.localScale = Vector3.one;
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "Target")
        {
            col.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            col.transform.localScale = Vector3.one / 1.1f;
        }
    }
}
