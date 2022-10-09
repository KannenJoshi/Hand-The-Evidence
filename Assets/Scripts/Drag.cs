using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler
{
    // https://www.youtube.com/watch?v=sXTAzcxNqv0
    [SerializeField] private Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        PointerEventData pointerData = (PointerEventData) eventData;

        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform) canvas.transform, pointerData.position,
            canvas.worldCamera, out pos);

        transform.position = canvas.transform.TransformPoint(pos);
    }
}
