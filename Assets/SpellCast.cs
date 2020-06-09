using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour
{
    public Transform firepoint;
    public GameObject SpellPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot ()
    {
        Instantiate(SpellPrefab, firepoint.position, firepoint.rotation);
    }
}
