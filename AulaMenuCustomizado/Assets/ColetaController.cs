using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColetaController : MonoBehaviour
{
    public int coinCounter = 0;
    public TMP_Text counterText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Coletavel") && collision.gameObject.activeSelf)
        {
            Destroy(collision.gameObject);
            coinCounter += 1;
            counterText.text = "Coletou: " + coinCounter;
        }
    }
}
