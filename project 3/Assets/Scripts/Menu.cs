using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject[] LetterPrefabs;
    private float spinSpeed = 1000;

    private Rigidbody targetRB;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        int LetterIndex = Random.Range(0, LetterPrefabs.Length);
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
        Instantiate(LetterPrefabs[LetterIndex], new Vector3(Random.Range(-200, 200), 100, 100), LetterPrefabs[LetterIndex].transform.rotation);
    }
}