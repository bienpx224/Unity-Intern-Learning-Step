using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [Header("List Color")] 
    [SerializeField] public Color colorButtonDefault;
    [SerializeField] public Color colorButton1;
    [SerializeField] public Color colorButton2;
    [Header("Player")]
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private TextMeshProUGUI bulletCount;
    private int bulletCountIndex = 5;
    // Start is called before the first frame update
    void Start()
    {
        bulletCount.SetText(bulletCountIndex.ToString());
        if (sprite == null)
        {
            sprite = GetComponent<SpriteRenderer>();
        }
    }
    private void Update()
    {
        RotateFollowMouse();
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }

    public void ChangeColor(Color color)
    {
        sprite.color = color;
        StopAllCoroutines();
        StartCoroutine(IEReturnDefaultColor());
    }

    private IEnumerator IEReturnDefaultColor()
    {
        yield return new WaitForSeconds(2f);
        ChangeColor(colorButtonDefault);
    }
    void RotateFollowMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        direction.z = 0;

        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction.normalized);
    }
    void Shooting()
    {
        if (bulletCountIndex > 0)
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bulletCountIndex -= 1;
            bulletCount.SetText(bulletCountIndex.ToString());

            if (bulletCountIndex <= 0)
            {
                Debug.Log("Out of bullet");
                Invoke("Reload", 2);
            }
        }
    }
    private void Reload()
    {
        Debug.Log("Reload called");
        bulletCountIndex = 5;
        bulletCount.SetText(bulletCountIndex.ToString());
    }
    private void OnDestroy()
    {
        Debug.Log("Game Destroyed");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
