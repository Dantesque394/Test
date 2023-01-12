using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // pour les objets
    public bool aChaussure = false;
    public bool aPapillon = false;
    public bool aBriquet = false;

    // pour le mouvement
    public float vitesse = 5;
    Rigidbody2D rb;
    float inputX;
    float inputY;
    Vector2 mouvement;
    public bool seRetourne = true;
    float tailleInitiale;

    // pour la gestion des pnjs
    private PnjParle pnjActif;
    private List<PnjParle> listePnjs = new List<PnjParle>();


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tailleInitiale = GetComponent<Transform>().localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        mouvement = (new Vector2(inputX, inputY)).normalized * vitesse;
        rb.velocity = mouvement;
        if(seRetourne && rb.velocity.x > 0)
        {
            transform.localScale = new Vector2(tailleInitiale, tailleInitiale);
        }
        if (seRetourne && rb.velocity.x < 0)
        {
            transform.localScale = new Vector2(-1*tailleInitiale, tailleInitiale);
        }
    }

    // pour les pnjs
    public void AjoutePnj(PnjParle newPnj)
    {
        if (pnjActif != null)
        {
            pnjActif.Deselect();
        }
        newPnj.Select();
        pnjActif = newPnj;
        listePnjs.Add(newPnj);
    }

    public void EnlevePnj(PnjParle PnjAEnlever)
    {
        PnjAEnlever.Deselect();
        listePnjs.Remove(PnjAEnlever);
        if(listePnjs.Count >= 1)
        {
            pnjActif = listePnjs[0];
            pnjActif.Select();
        }
        else
        {
            pnjActif = null;
        }
    }


}
