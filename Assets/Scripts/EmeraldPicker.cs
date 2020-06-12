using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmeraldPicker : MonoBehaviour
{
    private float emerald = 0;

    public TextMeshProUGUI textEmerald;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "emerald")
        {
            emerald++;
            textEmerald.text = emerald.ToString();

            Destroy(other.gameObject);
        }

    }

}
