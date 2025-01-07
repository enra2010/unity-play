using TMPro;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rg;

    public float speed;
    
    private int leftPoints, rightPoints;

    public TextMeshProUGUI textRight, textLeft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    private void Launch()
    {
        transform.position = Vector2.zero;
        float x = getFloatBiggerZero();
        float y = Random.Range(-1f, 1f);
        rg.linearVelocity = new Vector2(x * speed, y* speed);
    }

    private float getFloatBiggerZero()
    {
        while (true)
        {
            var result = Random.Range(-1f, 1f);
            if (result > 0.1 || result < -0.1)
            {
                return result;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBorder"))
        {
            rightPoints++;
            textRight.text = rightPoints.ToString();
            Launch();
        }
        else if (collision.gameObject.CompareTag("RightBorder"))
        {
            leftPoints++;
            textLeft.text = leftPoints.ToString();
            Launch();
        }
    }
    
}
