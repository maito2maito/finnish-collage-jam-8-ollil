using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    private Camera activeCamera;

    void Start()
    {
        // Asetetaan ensimmäinen kamera aktiiviseksi
        activeCamera = camera1;
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
    }

    void Update()
    {
        // Tarkistetaan, painetaanko C-näppäintä
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Vaihdetaan aktiivinen kamera
        if (activeCamera == camera1)
        {
            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);
            activeCamera = camera2;
        }
        else
        {
            camera2.gameObject.SetActive(false);
            camera1.gameObject.SetActive(true);
            activeCamera = camera1;
        }
    }
}
