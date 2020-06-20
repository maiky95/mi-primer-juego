using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickable : MonoBehaviour
{
    public bool IsStatic;
    public float SpawnDuration;
    private float Timer = 0.0f;
    private void Update()
    {

        if (IsStatic) return;
        
        Timer += Time.deltaTime;
        if (Timer >= SpawnDuration)
            Destroy(gameObject);
    }

    public abstract void PickupAction();

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerTriggerCollider"))
        {
            print("Trigger del objeto" + gameObject.name);
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            PickupAction();
            Destroy(gameObject);
        }
            
    }
}
