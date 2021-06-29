using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveL;
    private bool moveR;
    private float horizontal;
    private SpriteRenderer sr;
    private float speed = 5;
    [SerializeField] private Button botao;
    private bool canOpen;
    [SerializeField] private GameObject tela;
    private Animator anim;
    private AudioSource somPersonagem;
    public bool apareceBalao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveL = false;
        moveR = false;
        botao.interactable = false;
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        somPersonagem = GetComponent<AudioSource>();
    }

        void Update()
    {
        Movement();
    }
    
    public void PointerDownL()
    {
        if(moveR == false)
        {
            moveL = true;
            sr.flipX = true;
            GetComponent<Animator>().SetBool("andando", true);
            somPersonagem.Play();
        }
    }
    
    public void PointerUpL()
    {
        moveL = false;
        GetComponent<Animator>().SetBool("andando", false);
        somPersonagem.Pause();
    }
    
    public void PointerDownR()
    {
        if(moveL == false)
        {
            moveR = true;
            sr.flipX = false;
            GetComponent<Animator>().SetBool("andando", true);
            somPersonagem.Play();
        }
    }
    
    public void PointerUpR()
    {
        moveR = false;
        GetComponent<Animator>().SetBool("andando", false);
        somPersonagem.Pause();
    }

    private void Movement()
    {
        if(moveL)
        {
            horizontal = -speed;
        }
        else if(moveR)
        {
            horizontal = speed;
        }
        else
        {
            horizontal = 0;    
        }
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Interacao"))
        {
            Handheld.Vibrate();
            botao.gameObject.SetActive(true);
            botao.interactable = true;
            botao.image.sprite = col.GetComponent<Interagir>().botaoSprite;
            botao.image.SetNativeSize();
            tela = col.GetComponent<Interagir>().tela;
        }
    
        if(col.CompareTag("balao"))
        {
            apareceBalao = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if(col.CompareTag("Interacao"))
        {
            botao.interactable = false;
            botao.gameObject.SetActive(false);
            col.GetComponent<Interagir>().tela.SetActive(false);
        }
    
        if(col.CompareTag("balao"))
        {
            apareceBalao = false;
        }
    }

    public void Interagir()
    {
        if(botao.interactable == true)
        {
            tela.SetActive(true);
        }
    }
}