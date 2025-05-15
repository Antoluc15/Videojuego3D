using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public Transform player;
    public Transform goal;
    private float totalDistance;

    void Start()
    {
        totalDistance = Vector3.Distance(player.position, goal.position);
    }

    void Update()
    {
        float currentDistance = Vector3.Distance(player.position, goal.position);
        slider.value = 1 - (currentDistance / totalDistance);
    }
}
