using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCamara : MonoBehaviour
{
    Vector2 touchDeltaPosition;
    void Update()
    {
        if (Input.touchCount == 1)
        {
                Touch touchZero = Input.GetTouch(0);
            if (touchZero.phase == TouchPhase.Moved)
            {
                touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                gameObject.transform.Rotate(touchDeltaPosition.y * 0f, -touchDeltaPosition.x * .4f, 0);
            }
        }
        //Rotar camaras fijas (3)
        /*if (Input.GetMouseButton(0))
        {
            float pointer_x = Input.GetAxis("Mouse X");
            float pointer_y = Input.GetAxis("Mouse Y");
            transform.Rotate(-pointer_x * 0f, -pointer_y * 0.5f, 0);
        }*/
    }
}