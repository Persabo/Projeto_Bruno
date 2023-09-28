using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5.0f;
    public float forcaPulo = 8.0f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool olhandoDireita = true;
    private bool noChao = false;
    public Transform verificaChao;
    public LayerMask oQueEChao;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // Verifica se o jogador está no chão
        noChao = Physics2D.OverlapCircle(verificaChao.position, 0.2f, oQueEChao);

        float movimentoHorizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(movimentoHorizontal * velocidade, rb.velocity.y);

        bool estaAndando = Mathf.Abs(movimentoHorizontal) > 0.1f;
        //anim.SetBool("Andando", estaAndando);

        if (movimentoHorizontal > 0 && !olhandoDireita)
        {
            Inverter();
        }
        else if (movimentoHorizontal < 0 && olhandoDireita)
        {
            Inverter();
        }

        if (noChao && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, forcaPulo), ForceMode2D.Impulse);
            //anim.SetTrigger("Pular");
        }
    }

    private void Inverter()
    {
        olhandoDireita = !olhandoDireita;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}

