using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform kuskinkamera;

    private float xRotation = 0f;
    private float yRotation = 0f; // Uusi muuttuja horisontaaliselle liikkeelle

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Piilottaa kursorin ja lukitsee sen keskelle n�ytt��
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      

        

        yRotation += mouseX; // P�ivitet��n yRotation muuttujalla

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f); // Liikutetaan kameraa my�s sivuttaissuunnassa
    }
}