using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class ScreenBoundsCollider : MonoBehaviour
{
    void Start()
    {
        Camera cam = Camera.main;
        EdgeCollider2D edge = GetComponent<EdgeCollider2D>();

        // Get the screen corners in world coordinates
        Vector2 bottomLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector2 topLeft = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
        Vector2 topRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector2 bottomRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));

        // Set points for the edge collider in a loop
        Vector2[] points = new Vector2[5]
        {
            bottomLeft,
            topLeft,
            topRight,
            bottomRight,
            bottomLeft // close the loop
        };

        edge.points = points;
    }
}
