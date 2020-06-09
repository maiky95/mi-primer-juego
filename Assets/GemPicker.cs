using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemPicker : MonoBehaviour
{
    private float gems = 0;

    public TextMeshProUGUI textGems;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "gem")
        {
            gems++;
            textGems.text = gems.ToString();

            Destroy(other.gameObject);
        }
        
    }
            
 
}
