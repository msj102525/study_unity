using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [Header("Settings")]
    [Tooltip("How fast should the texture scroll?")]
    public float scrollSpeed;

    [Header("Referenes")]
    public MeshRenderer meshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        // meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * GameManager.Instance.CalculateGameSpeed() / 20 * Time.deltaTime, 0);
    }
}
