using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] private float speed;

    private void Awake() {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime,0); 
    }
}
