using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight;  // Döndürülecek ışık kaynağı
    public float dayDuration = 120f; // Bir günün geçmesi için gereken gerçek saniyeler (Denetçi'de düzenlenebilir)

    private float rotationSpeed;

    void Start()
    {
        // Gün boyunca 360 derece dönüş olacak, bu yüzden hız hesaplanır
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Işığı sürekli olarak yavaşça döndür
        directionalLight.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
