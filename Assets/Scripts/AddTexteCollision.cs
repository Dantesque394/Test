using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddTexteCollision : MonoBehaviour
{
    public string nouveauMot;  
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
            print("collision ok");
            GameObject.Find("Texte1").GetComponent<TextMeshProUGUI>().text += nouveauMot;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
             GameObject.Find("Texte1").GetComponent<TextMeshProUGUI>().text = "";
    }
   
}
