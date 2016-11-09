using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    private Hero hero;
	void Start ()
	{
	    hero = GetComponent<Hero>();
	}
	
	void Update () {
        
    }

    public void BlockClicked()
    {
        
    }

    public void Walk(float direction)
    {
        gameObject.transform.Translate(Vector3.right * direction);
        hero.Walk();
    }

    public void AttackClicked()
    {
        hero.Attack();
    }

    public void SpecialAttackClicked()
    {
        hero.SpecialAttack();
    }
}
