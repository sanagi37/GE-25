using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    //Dectection Point
    public Transform detectionPoint;
    //Dectection Radius
    private const float detectionRadius = 0.2f;
    //Detection Layer
    public LayerMask detectionLayer;
    void Update()
    {
        if(DetectObject())
        {
            if(InteractInput())
            {
                Debug.Log("Interactive");
            }
        } 
    }
    bool InteractInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }

    bool DetectObject()
    {
        return Physics2D.OverlapCircle(detectionPoint.position, detectionRadius,detectionLayer);
    }
}
