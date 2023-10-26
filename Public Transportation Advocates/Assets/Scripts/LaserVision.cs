using UnityEngine;
using System.Collections;

public class LaserVision : MonoBehaviour
{
	public Transform m_player;
	public GameObject m_shotPrefab;
	public Texture2D m_guiTexture;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject go = GameObject.Instantiate(m_shotPrefab, m_player.position, m_player.rotation) as GameObject;
			GameObject.Destroy(go, 3f);
		}
	}
}
