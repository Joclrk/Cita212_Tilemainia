using UnityEngine;

public class RotationObsticle : MonoBehaviour
{
    [SerializeField] float RotateSpd = 100f; 
    void Update()
    {
        Spin();
    }
    void Spin()
    {
        transform.Rotate(0f, 0f, RotateSpd); 
    }
}
