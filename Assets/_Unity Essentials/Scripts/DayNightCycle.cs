using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Тривалість повної доби в секундах")]
    public float dayDurationInSeconds = 60f;

    void Update()
    {
        // Розраховуємо швидкість обертання: 360 градусів ділимо на час доби
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Обертаємо об'єкт навколо осі X відносно світового простору
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.World);
    }
}