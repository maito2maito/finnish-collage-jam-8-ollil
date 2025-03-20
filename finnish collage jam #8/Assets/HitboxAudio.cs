using UnityEngine;
using UnityEngine.Events;

public class HitboxAudio : MonoBehaviour
{
    public AudioSource audioSource;  // Viittaus AudioSourceen, joka soittaa ‰‰nen
    public GameObject targetObject;  // Viittaus objektiin, jonka kanssa tˆrm‰t‰‰n
    public bool playOnEnter = true;  // M‰‰ritt‰‰, soittaako ‰‰nen heti osumassa
    public UnityEvent events;
    public UnityEvent eventsafterEnd;

    // Funktio, joka kutsutaan, kun toinen objekti osuu trigger-alueeseen
    void OnTriggerEnter(Collider other)
    {
        // Tarkistetaan, osuuko haluttuun objektiin
        if (other.gameObject == targetObject)
        {
            if (audioSource != null && !audioSource.isPlaying && playOnEnter)
            {
                audioSource.Play();  // Soitetaan ‰‰ni
                events.Invoke();
                Invoke("REstoreRadio", 46f);
            }
        }
    }

    void REstoreRadio()
    {
        eventsafterEnd.Invoke();
    }

    // Funktio, joka kutsutaan, kun toinen objekti poistuu trigger-alueesta

}