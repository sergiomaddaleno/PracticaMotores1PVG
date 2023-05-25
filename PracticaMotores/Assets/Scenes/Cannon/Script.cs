using UnityEngine;

public class ParabolaRaycast : MonoBehaviour
{
    public int resolution = 100;   // Number of raycasts to perform
    public float angle = 45f;      // Angle of the parabolic trajectory
    public float velocity = 10f;   // Initial velocity of the projectile
    public float gravity = 9.8f;   // Acceleration due to gravity
    public float maxHeight = 5f;   // Maximum height of the parabola

    private LineRenderer lineRenderer;

    private void Start(){
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = resolution + 1;
    }

    private void Update(){
        DrawParabola();
    }

    private void DrawParabola(){
        float stepSize = maxHeight / resolution;
        float time = 0f;

        for (int i = 0; i <= resolution; i++){
            float x = velocity * time * Mathf.Cos(Mathf.Deg2Rad * angle);
            float y = velocity * time * Mathf.Sin(Mathf.Deg2Rad * angle) - 0.5f * gravity * time * time;
            float z = velocity * time * Mathf.Sin(Mathf.Deg2Rad * angle) - 0.5f * gravity * time * time; // Modify the z coordinate to achieve a 3D parabola

            lineRenderer.SetPosition(i, new Vector3(x, y, z));

            time += stepSize;
        }
    }
}

