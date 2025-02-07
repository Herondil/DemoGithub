//using : référence vers du code extérieur
// "import" 
using UnityEngine;

//créer une nouvelle classe qui hérite de Mono Behaviour
public class LogWhenCollision : MonoBehaviour
{

    public float message;

    //Message envoyé par Unity au début de l'éxécution : appelé qu'une seule fois
    private void Start()
    {
        
    }

    //Message envoyé par Unity à chaque Update, à chaque frame
    private void Update()
    {
        //on ne sait pas quand va avoir lieu la prochaine update

        //Debug.Log("Coucou");
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name);
        //affecte la position (0,0,0)

        //Qui contrôle transform ?
        transform.position = new Vector3(0, 0, 0);


      
    }
}