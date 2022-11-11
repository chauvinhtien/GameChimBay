using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    //Khai Báo Game Object Game Manager
    [SerializeField] GameObject gameManager;
    private GameManager gManager;
    //Khai báo kiểu dữ liệu Vector3(x,y,z)
    private Vector3 direction;

    //Lực nhảy lên
    [SerializeField]
    private float strenght = 5f;


    //Khai báo biến cho trọng lực
    [SerializeField] private float gravity;
    

    // Start is called before the first frame update
    private void Start()
    {
        gManager = gameManager.gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))  // Hoặc trong C# là "||" : //GetMouseButtonDown(0) = nhấn chuột trái
        {
            direction = Vector3.up * strenght; // Vector3.up = new Vector3(0,1,0)
        }
        

        //Cộng biến Vector3() "direction" với biến "gravity" 
        direction.y += gravity * Time.deltaTime; //=> nhân Time.deltaTime để k có sự chênh lệch khi các máy có tốc độ phát khác nhau.
        transform.position += direction * Time.deltaTime; //=> thay đổi vị trí của con chim theo Vector3 "direction" đã được cộng thên ở trên.
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            gManager.GameOver();
        }
        if(other.gameObject.tag == "Point")
        {
            Debug.Log("cộng 1 điểm");
        }
    }                                     
}
