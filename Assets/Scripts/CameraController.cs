using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Orientation;

    public float MouseSensitivityCoefficient = 0.5F;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseX = Input.GetAxis("Mouse X");
        var mouseY = Input.GetAxis("Mouse Y");

        var rotateValue = new Vector3(mouseY, mouseX * -1, 0) * MouseSensitivityCoefficient;
        transform.eulerAngles -= rotateValue;
        Orientation.eulerAngles -= rotateValue;
    }
}
