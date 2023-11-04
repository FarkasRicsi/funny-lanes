using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenBehaviour : MonoBehaviour
{
    [SerializeField]
    public float speed = 3.0f;

    [SerializeField]
    public SpriteRenderer spriteRenderer;

    //Protected: Child classes can see, others don't.
    protected GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();//Todo: Refactor to TokenBehaviour.
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
    public virtual void OnTriggerEnter2D(Collider2D collision)
    {   
        Destroy(this.gameObject);
    }
}
