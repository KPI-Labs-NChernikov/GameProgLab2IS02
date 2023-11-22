using UnityEngine;

public class CameraHolderController : MonoBehaviour
{
    public Transform CameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = CameraPosition.position;
    }
}
