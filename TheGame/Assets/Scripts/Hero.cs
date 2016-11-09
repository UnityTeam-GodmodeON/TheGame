using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour
{
    public int Health;
    private bool blocking;
    private int Cooldown; //Will be something different
    private bool Walking;
    private Animator anim;

    void Start()
    {
        Health = 100;
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
        anim.SetBool("Moving", Walking);
        Walking = false;
    }

    public void TakeDamage(int value, string attackType)
    {
        int damage = value;
        if (attackType == "normal")
        {
            damage = damage / 2;
        }
        Health -= damage;
    }

    public void Block()
    {
        //anim.SetBool("Blocking", true);
    }

    private void Die()
    {
        anim.SetTrigger("Death");
    }

    public void SpecialAttack()
    {
        if (Cooldown <= 0)
        {
            anim.SetTrigger("SpecialAttack");
        }
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
    }

    public void Walk()
    {
        Walking = true;
    }
}
