using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDP : MonoBehaviour
{
    public string motDePasse;

    int compteur = 0;


    // Start is called before the first frame update
    void Start()
      {
        
         if (motDePasse == "Sammy")
         {
         print("identification r�ussie");
         }
         else
         {
         print("mauvais mot de passe");
         }
      }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
            compteur += 1;
            if(compteur >= 12)
            {
                print("Vous avez appuy� 12 fois sur espace");
                compteur = 0;
            }
         }    
    }
}
