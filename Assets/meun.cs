using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meun : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
       
        Application.Quit();
        Debug.Log("Game is exiting"); 
    }
    public void Start()
    {
        SceanManager.LoadScene("FirstLevel");
        Debug.Log("Game is starting");
    }
}
