using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{

    public Animator animator;

    private void Awake()
    {
<<<<<<< HEAD
        // SetBoll, Getbool, SetInt, GetInt, SetTrigger, ResetTrigger
=======
>>>>>>> d2cb7794584e51375725bffcbe2437401ea7b54a
        animator.SetBool("Abrir",false);
    }

    public void AbrirCerrarPuerta()
    {

        animator.SetBool("Abrir", !animator.GetBool("Abrir"));
<<<<<<< HEAD
=======

>>>>>>> d2cb7794584e51375725bffcbe2437401ea7b54a
    }

}
