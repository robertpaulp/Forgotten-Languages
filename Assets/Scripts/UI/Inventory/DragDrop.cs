using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private UIItem item;

    public void Awake()
    {
        canvas = transform.root.GetComponent<Canvas>();
        item = GetComponentInChildren<UIItem>();
        Default();
    }

    public void SetData(Sprite sprite, int level, string name, bool stackable, string description, int max)
    {
        item.SetData(sprite, level, name, stackable, description, max);
    }

    public void Default()
    {
        item.Default();
    }
    void Update()
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            Input.mousePosition,
            canvas.worldCamera,
            out position
                );
        transform.position = canvas.transform.TransformPoint(position);
    }

    public void Toggle(bool val)
    {
        gameObject.SetActive(val);
    }
}
