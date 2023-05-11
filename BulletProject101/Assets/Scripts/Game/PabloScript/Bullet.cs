using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	private PointManager pointManager;

	void Start()
	{
		pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.GetComponent<EnemyMovement>())
		{
			Destroy(collision.gameObject);
			pointManager.UpdateScore(100);
			Destroy(gameObject);
		}

		if (collision.GetComponent<MovementBoss>())
		{
			pointManager.UpdateScore(100);
			Destroy(gameObject);
		}
	}
}
