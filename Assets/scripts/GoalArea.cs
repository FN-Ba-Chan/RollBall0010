using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GoalArea : MonoBehaviour
{
    public TextMeshProUGUI goalText;
    public AudioSource audioSource;
 
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.tag == "Player")
            {
                Debug.Log("ÉSÅ[ÉãÇµÇΩÇÊÅI");
                goalText.text = $"GOAL!";
                audioSource.Play();
            }
        }
    }
}
