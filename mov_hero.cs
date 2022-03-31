using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mov_hero : MonoBehaviour
{
  
    public bool face = true;
    public Transform heroiT;
    public float vel = 2.5f;
    public float force=6.5f;
    public Rigidbody2D heroiRB;
    public bool liberarpulo = false;
    public float speed;
    public Animator anim;
    public bool vivo = true;
    public bool isJumping;
    public float JumpForce;
    private string ar;

    void Start()
    {
        heroiT = GetComponent<Transform>();
        heroiRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
        
    }

    void Update()
    {
        if(vivo == true)//ANIMAÇÃO VIRAR POR LADO E OUTRO
        {
            if(Input.GetKey(KeyCode.RightArrow)&& !face)
        {
            Flip();   
        }
        else if (Input.GetKey(KeyCode.LeftArrow)&& face)
        {
            Flip(); 
        } }
    
        if(vivo == true)
        {
           if (Input.GetKey(KeyCode.RightArrow))//ANIMAÇÃO ANDAR 
        {
            transform.Translate(new Vector2(vel *Time.deltaTime,0));
            anim.SetBool("hero_correr",true);
            anim.SetBool("hero_idle",false);
	        
        }
          else if (Input.GetKey(KeyCode.LeftArrow))//ANIMAÇÃO ANDAR
        {
            transform.Translate(new Vector2(-vel *Time.deltaTime,0));
            anim.SetBool("hero_idle",false);
	        anim.SetBool("hero_correr",true);
        }
          else  
        {
            anim.SetBool("hero_idle",true);
	        anim.SetBool("hero_correr",false);
        }
        }     
    }
    

    void Flip()//OLHAR PARA UM LADO POR OUTRO
    {
        face =!face;

        Vector3 scala = heroiT.localScale;
        scala.x *=-1;
        heroiT.localScale = scala;

    }
    

     void OnCollisionEnter2D (Collision2D  outro) //COLISÃO
    {
        if (outro.gameObject.CompareTag("Vilao"))
        {//Se hero colidir com vilão morte
			vivo = false;
			anim.SetBool("hero_morrer",true);
	        anim.SetBool("hero_correr",false);
            SceneManager.LoadScene(6);
			
		}

    }
	
}
