using UnityEngine;
using UnityEngine.InputSystem;
public class item : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public PlayerMovement script;
    public Material empty;
    public Material m1;
    public Material m2;
    public Material m3;
    public Material buttonprompt;
    public Material items;
    public float value = 1;
     public bool var1;
     public bool var2;
    /*public bool itempressed;
   
    public void OnDrift(InputValue val)
    {
        itempressed = val.isPressed;
    }*/
    void Start()
    {
       if (meshRenderer == null) 
            meshRenderer = GetComponent<MeshRenderer>();
       
        
    }

    void Update()
    {
    if (script.currentSpeed > 40)
        {
            value += Time.deltaTime;
        }
     if (value >= 20){
        meshRenderer.material = buttonprompt;
        var1 =true;}
    else if (value >= 15)
        meshRenderer.material = m3;
    else if (value >= 10)
        meshRenderer.material = m2;
    else if (value >= 5)
        meshRenderer.material = m1;
    else
        meshRenderer.material = empty;
    if (script.itempressed)
    {
        if (!var1)
            {
                
            }
        else if (var1)
            {
               var1 = false;
               var2 = true;
            }
        
    }
    if (var2)
        {
        meshRenderer.material = items;
        }
}}