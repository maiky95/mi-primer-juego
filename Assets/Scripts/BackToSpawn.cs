using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToSpawn : MonoBehaviour
{
    private void OnBecameInvisible()
    {

        transform.parent.transform.position = new Vector3(-15, -2, 0);
    }

}
