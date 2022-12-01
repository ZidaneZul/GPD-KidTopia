using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] babies;

    private int intelligence, charisma, health;

    private int life = 70;

    void Start()
    {
        intelligence = Random.Range(0, 100); //how smort
        charisma = Random.Range(0, 100); // how well they can bargain etc
        health = Random.Range(0, 100); // life expectancy


        Debug.Log("Int " + intelligence + "\n"
            + "Charisma " + charisma + "\n"
            + "Health " + health);
    }
    private void Update()
    {
        
    }
    void RandomEvent()
    {

    }
}
