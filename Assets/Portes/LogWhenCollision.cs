//using : r�f�rence vers du code ext�rieur
// "import" 
using UnityEngine;

//cr�er une nouvelle classe qui h�rite de Mono Behaviour
public class LogWhenCollision : MonoBehaviour
{

    public float message;

    //Message envoy� par Unity au d�but de l'�x�cution : appel� qu'une seule fois
    private void Start()
    {
        
    }

    //Message envoy� par Unity � chaque Update, � chaque frame
    private void Update()
    {
        //on ne sait pas quand va avoir lieu la prochaine update

        //Debug.Log("Coucou");
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name);
        //affecte la position (0,0,0)

        //Qui contr�le transform ?
        transform.position = new Vector3(0, 0, 0);


      
    }
}