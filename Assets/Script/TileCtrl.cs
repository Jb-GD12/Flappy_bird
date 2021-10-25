using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TileCtrl : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D m_rb;
    /*[HideInInspector]*/ public TileManager m_tileManager;
    private BoxCollider2D m_boxCollider;

    [SerializeField] private float m_moveForce;
    private bool m_spawn = false;

    private float m_destroyCoor;
    private float m_spawnCoor;

    // Start is called before the first frame update
    void Start()
    {
        m_boxCollider = GetComponent<BoxCollider2D>();
        m_destroyCoor = m_boxCollider.size.x * -1;
        m_spawnCoor = m_boxCollider.size.x / 0.5f * -1;
    }

    // Update is called once per frame
    void Update()
    {
        m_rb.velocity = Vector2.left * m_moveForce * Time.deltaTime;

        if (transform.position.x <= -8f && !m_spawn)
        {
            m_tileManager.SpawnTile();
            m_spawn = true;
        }
        
        if (transform.position.x <= m_destroyCoor)
        {
            Destroy(gameObject);
        }
    }
}
