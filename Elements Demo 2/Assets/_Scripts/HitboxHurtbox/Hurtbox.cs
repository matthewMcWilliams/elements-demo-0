using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    [SerializeField] private int maxHealth;

	private int hp;

	public int Hp
	{
		get { return hp; }
		private set { 
			hp = Mathf.Clamp(value, 0, maxHealth); 
			if (hp <= 0)
				Destroy(transform.root.gameObject);
		}
	}


	private void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log(collider);
		if (collider.TryGetComponent(out Hitbox hitbox))
		{
			Hp-=hitbox.damage;

		}

	}
}
