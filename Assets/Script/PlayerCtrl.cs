using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_rb;
    
    [SerializeField] private float m_jumpForce;
    
    [SerializeField] private float m_maxSpeedYUp;
    [SerializeField] private float m_maxSpeedYDown;
    
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //rotation avec clamp
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rb.AddForce(Vector2.up * m_jumpForce, ForceMode2D.Force);

            if (m_rb.velocity.y > 1f)
            {
                m_rb.velocity = new Vector2(0f, m_maxSpeedYUp);
            }else if (m_rb.velocity.y < -1f)
            {
                m_rb.velocity = new Vector2(0f, m_maxSpeedYDown);
            }
        }
    }

    void FixedUpdate()
    {
        //force impulse
        
    }

    public void Death()
    {
        
    }
}
