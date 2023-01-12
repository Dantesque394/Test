using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

     int viepika;
     int viebulbi;
     int attaquebulbi;
     int attaquepika;

    // Start is called before the first frame update
    void Start()
    {
         print("combat pokemon");

         viepika = 50;
         viebulbi = 60;

         print("Vie Bulbizarre : " + viebulbi);
         print("Vie Pikachu : " + viepika);

         attaquebulbi = 5;
         attaquepika = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            {
                viebulbi = viebulbi - attaquepika;
                print ("Pikachu utilise éclair il reste a Bulbizarre " + viebulbi + " HP");
            }
        if (Input.GetKeyDown(KeyCode.B))
            {
                viepika = viepika - attaquebulbi;
                print ("Bulbizarre utilise engrais il reste a Pikachu " + viepika + " HP");
            }
    }
 
 
}