using UnityEngine;
using TMPro;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField;
    public TextMeshProUGUI contentField;
    public LayoutElement layoutElement;
    public int characterWrapLimit;
    public RectTransform rectTransform;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetText(string content, string header = "")
    {
        if (string.IsNullOrEmpty(header))
        {
            headerField.gameObject.SetActive(false);
        }
        else
        {
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }
        contentField.text = content;

        int headerLenght = headerField.text.Length;
        int contentLenght = contentField.text.Length;

        layoutElement.enabled = (headerLenght > characterWrapLimit || contentLenght > characterWrapLimit) ? true : false;

    }

    private void Update()
    {
        if (Application.isEditor) 
        {
            int headerLenght = headerField.text.Length;
            int contentLenght = contentField.text.Length;

            layoutElement.enabled = (headerLenght > characterWrapLimit || contentLenght > characterWrapLimit) ? true : false;
        }

        float rectSizeY = rectTransform.rect.height;
        float rectSizeX = rectTransform.rect.width;
        Vector2 position = Input.mousePosition + new Vector3(rectSizeX / 2f, -rectSizeY / 2f, 0f);

        float pivotX = position.x / Screen.width;
        float pivotY = position.y / Screen.height;

        rectTransform.pivot = new Vector2(pivotX, pivotY);
        transform.position = position;

    }
}
