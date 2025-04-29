using UnityEngine;

public class GerakPindah : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float speed = 3f;
    [SerializeField] private GameObject[] characterPrefabs;

    private GameObject activeCharacter;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 startPos;
    private bool isDragging = false;

    void Start()
    {
        int index = Random.Range(0, characterPrefabs.Length);
        activeCharacter = Instantiate(characterPrefabs[index], transform);
        activeCharacter.transform.localPosition = Vector3.zero;
    }

    void Update()
    {
        if (!isDragging)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        startPos = transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.WorldToScreenPoint(curScreenPoint) + offset;
        transform.position = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    }

    void OnMouseUp()
    {
        transform.position = startPos;
        isDragging = false;
    }
}
