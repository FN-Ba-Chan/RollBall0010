using UnityEngine;

public class Createball : MonoBehaviour
{
    public GameObject BallPrefab;

  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(BallPrefab);
    }

    // Update is called once per frame
   
}
