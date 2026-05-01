using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerDirection : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    
        public PlayerMovement movementScript; 

    public Material materialLeft;
    public Material materialRight;
    public Material materialIdle;

    void Start()
    {
        if (meshRenderer == null) 
            meshRenderer = GetComponent<MeshRenderer>();

        
        if (movementScript == null)
            movementScript = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        
        float currentRot = movementScript.rotation;

        if (currentRot < 0)
        {
            meshRenderer.material = materialRight;
        }
        else if (currentRot > 0)
        {
            meshRenderer.material = materialLeft;
        }
        else if (materialIdle != null)
        {
            meshRenderer.material = materialIdle;
        }
    }
}
