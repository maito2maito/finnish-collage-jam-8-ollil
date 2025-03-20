using UnityEngine;

public class AutoradioMute : MonoBehaviour
{
    public AudioSource audioSource;  
    public float muteDuration = 2f;  
    public GameObject hitboxObject; 

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject == hitboxObject)
        {
            MuteAudio();
        }
    }

    void MuteAudio()
    {
        
        audioSource.mute = true;

       
        StartCoroutine(RestoreAudioAfterDelay());
    }

    System.Collections.IEnumerator RestoreAudioAfterDelay()
    {
    
        yield return new WaitForSeconds(muteDuration);


        audioSource.mute = false;
    }
}
