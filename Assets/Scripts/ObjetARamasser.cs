using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetARamasser : MonoBehaviour
{
    // permet de changer le nom des objets dans unity
    public string nomObjet;

    // Start is called before the first frame update
    void Start()
    {
       GameObject.Find(nomObjet + " inventaire").GetComponent<Image>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // dit ce qu'il va se passer au moment de la collision et selon l'objet
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (nomObjet == "chaussure")
        {
            GameObject.Find("Player").GetComponent<Player>().aChaussure = true;
        }
        else if (nomObjet == "papillon")
        {
            GameObject.Find("Player").GetComponent<Player>().aPapillon = true;
        }
        else if (nomObjet == "briquet")
        {
            GameObject.Find("Player").GetComponent<Player>().aBriquet = true;
        }

        GameObject.Find(nomObjet + " inventaire").GetComponent<Image>().enabled = true;
        Destroy(gameObject);
    }
}
