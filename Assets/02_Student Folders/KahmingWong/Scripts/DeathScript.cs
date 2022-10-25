using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {
	public GameObject Player;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject == Player) {
			Destroy(Player);
		}
	}
}