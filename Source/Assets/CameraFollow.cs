using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public float xMargin = 1f;      // a distancia que a camera se movimentara antes de seguir o jogador no eixo x
    public float yMargin = 1f;      // a distancia que a camera se movimentara antes de seguir o jogador no eixo y
    public float xSmooth = 3f;      // o quao suave a camera se movimentara para o eixo x
    public float ySmooth = 3f;      // o quao suave a camera se movimentara para o eixo y
    public Vector2 maxXAndY;        // o maximo da coordenada da camera no eixo x e y
    public Vector2 minXAndY;        // o minimo da coordenada da camera no eixo x e y


    private Transform player;        // referencia para o alvo determinado no caso player


    void Awake()
    {
        //procura um objeto com a tag Player
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    bool CheckXMargin()
    {
        // retorna verdadeiro caso o eixo x for maior que o margin x
        return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
    }


    bool CheckYMargin()
    {
        // retorna verdadeiro caso o eixo y for maior que o margin y
        return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
    }


    void FixedUpdate()
    {
        //alvo a ser seguido
        TrackPlayer();
    }


    void TrackPlayer()
    {
        //Por padrão, as coordenadas  x e y da câmera são as coordenadas x e y atuais.
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        // se o Player se mover alem do eixo x
        if (CheckXMargin())
            // a coordenada  x deve ser um Lerp entre a posição x atual da câmera e a posição x atual do jogador.
            targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);

        // If the player has moved beyond the y margin...
        if (CheckYMargin())
            //a coordenada  x deve ser um Lerp entre a posição y atual da câmera e a posição y atual do jogador.
            targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);

        // As coordenadas  x e y não devem ser maiores que o máximo ou menores que o mínimo.
        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        // define a posição da câmera para a posição determinada com o mesmo eixo z.
        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
