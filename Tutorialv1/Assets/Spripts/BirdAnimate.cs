using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimate : MonoBehaviour
{
    //Tạo biến "spriteRenderer"
    private SpriteRenderer spriteRenderer;

    // Tạo dãy để chứa hình ảnh (dạng "Sprite")
    [SerializeField]
    private Sprite[] sprites;


    //Tạo biến số nguyên để truy xuất các hình trong Dãy đã tạo
    private int spriteIndex = 0;


    //Hàm Awake được gọi khi một Object đc enable
    private void Awake()
    {
        //Lấy Class "SpriteRenderer" để cho vào biến "spriteRenderer"
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating dùng để gọi một hàm lặp đi lặp lại theo khoản thời gian nhất định.
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);
    }


    //Hàm này dùng để phát hình ảnh trong dãy "sprites" đã tạo.
    private void AnimateSprite()
    {
        spriteIndex += 1;
        if(spriteIndex >= sprites.Length)// sprites.lenght lấy độ dài của dãy "sprites"
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
