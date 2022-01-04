using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class Sinewave : MonoBehaviour
{
    LineRenderer lineRenderer;
    static float Tau = 6.2831853f;

    public int points;

    public float amplitude = 1;
    public float frequency = 1;
    public Vector2 xLimits = new Vector2(-1,1);

    public bool moveWithTime;
    public float speedTime = 1;

    public float xScale;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }
    
    void Draw(){
        lineRenderer.positionCount = points;

        if(xScale == 0){
            xScale = 1;
        }

        Vector2 scaledX = xLimits * xScale;
        float xLength = scaledX.y - scaledX.x;
        float initialX = scaledX.x;

        for(int currentPoint = 0; currentPoint<points; currentPoint++){
            float currentX = initialX + ((float)currentPoint/(points-1))*xLength;
            float time = Time.timeSinceLevelLoad * speedTime;

            if(!moveWithTime){
                time = 0;
            }
            float y = amplitude * Mathf.Sin(currentX*Tau*frequency/xScale+time);
            lineRenderer.SetPosition(currentPoint, new Vector3(currentX,y,0));

        }
    }
}
