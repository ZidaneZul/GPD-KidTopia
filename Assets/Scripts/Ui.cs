using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject Baby;
    public Transform SpawnPoint;

    public GameObject window;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBaby()
    {
        window.SetActive(true);
        Instantiate(Baby, SpawnPoint);
    }
    public void CloseWindow()
    {
        window.SetActive(false);
    }
    public void LeftButton()
    {

    }
    public void RightButton()
    {

    }
}
