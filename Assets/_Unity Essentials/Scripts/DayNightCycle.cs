using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("How many real-time seconds a full day takes")]
    public float dayDuration = 60f; // 60 seconds = 1 full day

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees divided by total seconds in a day
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around X-axis (sun movement)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}