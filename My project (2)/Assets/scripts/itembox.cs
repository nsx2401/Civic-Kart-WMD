using UnityEngine;
using UnityEngine.InputSystem;
public class itembox : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public PlayerMovement script;
    public Material material1;
    public Material material2;
    public Material material3;
    public Material material4;
     public Material material5;
      public Material material6;
       public Material material7;
        public Material material8;
         public Material material9;
          public Material material10;
           public Material material11;
            public Material material12;
             public Material material13;
              public Material material14;
              public Material material15;
    public float Speed;
/*    public void setSpeed(float currentSpeed)
    {
        this.Speed = currentSpeed;
    }
    */
    void Start()
    {
       if (meshRenderer == null) 
            meshRenderer = GetComponent<MeshRenderer>();
       
        
    }

    void Update()
    {
        float Speed = script.cs;
       Debug.Log(Speed);
        if (Speed < 4) 
        {
        meshRenderer.material = material1;
        } 
        if(Speed > 4 && Speed < 8)
        {
        meshRenderer.material = material2;
        }
        if (Speed > 8 && Speed < 12) 
        {
        meshRenderer.material = material3;
        } 
         if(Speed > 12 && Speed < 16)
        {
        meshRenderer.material = material4;
        }
        if (Speed > 16 && Speed < 20) 
        {
        meshRenderer.material = material5;
        } 
        if (Speed > 20 && Speed < 24) 
        {
        meshRenderer.material = material6;
        } 
        if (Speed > 24 && Speed < 28) 
        {
        meshRenderer.material = material7;
        }
        if (Speed > 28 && Speed < 32) 
        {
        meshRenderer.material = material8;
        }
        if (Speed > 32 && Speed < 36) 
        {
        meshRenderer.material = material9;
        }
        if (Speed > 36 && Speed < 40) 
        {
        meshRenderer.material = material10;
        } 
        if (Speed > 40 && Speed < 42) 
        {
        meshRenderer.material = material11;
        } 
        if (Speed > 42 && Speed < 44 ) 
        {
        meshRenderer.material = material12;
        } 
        if (Speed > 44 && Speed < 46) 
        {
        meshRenderer.material = material13;
        } 
        if (Speed > 46 && Speed < 48) 
        {
        meshRenderer.material = material14;
    }
    if (Speed > 48) 
        {
        meshRenderer.material = material15;
        } 
}}
