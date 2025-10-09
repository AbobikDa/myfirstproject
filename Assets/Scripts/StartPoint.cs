using UnityEngine;

public class StartPoint : MonoBehaviour
{
    private void Start()
    {
        var startPoint = FindAnyObjectByType<StartTag>();
        var startTransform = startPoint.GetComponent<Transform>();
        transform.position = startTransform.position;
    }
}
