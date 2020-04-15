using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] WoordenPrefabs;
    private float InstantiationTimer = 2f;
    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOver;
    // Start is called before the first frame update
    void Start() 
    {
     
    }

    // Update is called once per frame



    void Update()
    {

        score = 0;
        UpdateScore(0);
        int LetterIndex = Random.Range(0, WoordenPrefabs.Length);

        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            Instantiate(WoordenPrefabs[LetterIndex], new Vector3(Random.Range(-200, 200), 100, 100), Quaternion.identity);
            InstantiationTimer = 2f;
        }




        if (transform.position.y < -100)
        {
            Destroy(gameObject);
        }


    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "score = " + score;
    }

    public void StartGame()
    {
        score = 0;
        UpdateScore(0);
    }
}
