using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform camTransform;

    void Start()
    {
        // Cache the main camera's transform for better performance
        camTransform = Camera.main.transform;
    }

    void LateUpdate()
    {
        // Method A: Makes the object look directly at the camera position
        transform.LookAt(camTransform.position);
        
        // Note: Standard Unity Planes are horizontal (Y-up). 
        // If your texture is on a Plane, you may need to rotate it 90 degrees on the X axis 
        // or use a 'Quad' primitive which is vertical by default.
    }
}

