using JetBrains.Annotations;
using UnityEngine;

public class Createball : MonoBehaviour
{
    public GameObject BallPrefab;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        var stageOut = GetComponent<StageOut>();
        if (stageOut != null)
        {
            int life = stageOut.Life;
        }
        BallCreate();
        Debug.Log($"{stageOut.Life}");
    }

    public void BallCreate()
    {
    
     //   if (stageOut.Life <= 0)
        {
            
        }
        Instantiate(BallPrefab);
    }

    // Update is called once per frame
   
}
