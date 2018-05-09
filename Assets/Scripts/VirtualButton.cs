using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler {

    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;
    public void OnButtonPressed(VirtualButtonBehaviour vb)

    {
        //el pajaro va a cantar cuando se presione el virtual button (cuando el dedo se ponga encima del boton)
        birdAnim.SetTrigger("sing");
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Use this for initialization
    void Start () {

        /*
         *Esto va a hacer que se obtenga el componente VirtualButtonVehaviour y se registre este mismo script como manejador de 
         * eventos del boton.
         */
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
