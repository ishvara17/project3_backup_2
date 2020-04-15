using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class target : MonoBehaviour
{
    private Rigidbody targetRb;
    public ParticleSystem explosionParticle;
    private int score;
    public TextMeshProUGUI scoreText;
    private GameManager gameManager;
    public int PointValue;


    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        var mousePos = Input.mousePosition;
        score = 0;
        UpdateScore(0);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }



    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(PointValue);
        //Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score = " + score;
    }

}



