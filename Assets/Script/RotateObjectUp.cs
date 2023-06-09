using UnityEngine;
using UnityEngine.EventSystems;
public class RotateObjectUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject rotatedObject;
    public float rotationSpeed = 20;
    bool rotate = false;
 
    void FixedUpdate()
    {
        if (rotate == false)
            return;
 
        rotatedObject.transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }
 
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
    }
 
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotate = false;
    }
}