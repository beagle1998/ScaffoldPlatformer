using UnityEngine;

public class OutOfBoundsDeath : MonoBehaviour
{
   // [SerializeField] int lower_x;
    [SerializeField] int lower_y;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

   


    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= lower_y)
        {
            gameManager.GameOver();
        }

    }
}
