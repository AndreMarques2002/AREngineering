using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {
    
        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Moved)
            {
                Vector2 rot = new Vector2(t.deltaPosition.y, t.deltaPosition.x*-1);
                transform.Rotate(rot * 5 * Time.deltaTime, Space.World);
            }
        
        }
    
    }
}
