using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchSpreadController : MonoBehaviour
{
    public GameObject target;
    public float initialTouchTime = 2;
    private float touchTime;
    private Renderer _rend;
    public float grownSpeed = 0.005f;

    private void Start()
    {
        touchTime = initialTouchTime;
        _rend = target.GetComponent<Renderer>();
    }
    private void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch secondTouch = Input.GetTouch(1);

            
            Vector2 firstTouchPrev = firstTouch.position - firstTouch.deltaPosition;
            Vector2 secondTouchPrev = secondTouch.position - secondTouch.deltaPosition;

            float prevTouchDeltaMag = (firstTouchPrev - secondTouchPrev).magnitude;
            float touchDeltaMag = (firstTouch.position - secondTouch.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            if (target.transform.localScale.magnitude > 0 && target.transform.localScale.magnitude < 20)
            {
                Vector3 scaledV= new Vector3(target.transform.localScale.x - deltaMagnitudeDiff*grownSpeed, target.transform.localScale.y - deltaMagnitudeDiff*grownSpeed, target.transform.localScale.z - deltaMagnitudeDiff*grownSpeed);
                target.transform.localScale = new Vector3(Mathf.Clamp(scaledV.x, 1, 10), Mathf.Clamp(scaledV.y, 1, 10), Mathf.Clamp(scaledV.z, 1, 10));
            }

        }

        if (Input.touchCount == 1 )
        {
            touchTime -= Time.deltaTime;
            if (touchTime <= 0)
            {
                _rend.material.color= new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                touchTime = initialTouchTime; ;
            }
        }


    }
}
