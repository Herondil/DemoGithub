using UnityEngine;
using UnityEngine.InputSystem;


public class InputTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //r�f�rence vers le clavier actuellement "branch�"
        var keyboard = Keyboard.current;

        if(keyboard.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Espace a �t� appuy� cette frame");


            //
        }

    }
}
