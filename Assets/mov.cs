using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    
    bool isLeftButtonDown;
	bool isRightButtonDown;
	bool isMiddleButtonDown;
	Renderer rend;
	Vector3 m;
	public Vector3 rotateChange;
	public Vector3 rotateChange2;
	public Vector3 positionChange;


	// Start is called before the first frame update
	void Start()
	{

		isLeftButtonDown = false;
		isRightButtonDown = false;
		isMiddleButtonDown = false;
		m.x = 0.0f;
		m.y = 0.0f;
		m.z = 0.0f;

		rend = GetComponent<Renderer>();
	}

	// Update is called once per frame
	void Update()
	{

		{

			if (Input.GetKey(KeyCode.W))
			{
				m.x = 0.1f;
				Movimento(m);
				m.x = 0.0f;
			}
			if (Input.GetKey(KeyCode.S))
			{

				m.x = -0.1f;
				Movimento(m);
				m.x = 0.0f;


			}
			if (Input.GetKey(KeyCode.D))
			{
				m.z = -0.1f;
				Movimento(m);
				m.z = 0.0f;
			}
			if (Input.GetKey(KeyCode.A))
			{
				m.z = 0.1f;
				Movimento(m);

			}
			isLeftButtonDown = Input.GetMouseButtonDown(0);
			isRightButtonDown = Input.GetMouseButtonDown(1);
			isMiddleButtonDown = Input.GetMouseButtonDown(2);

			if (isLeftButtonDown)
			{
				m.x = 0.5f;
				Rotacao(m);
								transform.Rotate(rotateChange);

				isLeftButtonDown = false;

			}

			if (isRightButtonDown)
			{
				transform.Rotate(rotateChange2);
				isRightButtonDown = false;
			}

			if (isMiddleButtonDown)
			{

			}
			if (Input.GetKey(KeyCode.Space))
			{
				transform.position += positionChange;
			}



		}
		void Rotacao(Vector3 x)
		{
			transform.Rotate(x);
		}
		void Movimento(Vector3 m)
		{
			transform.Translate(m);
		}

		void LogMessage(string msg)
		{
			Debug.Log("A opção selecionada foi " + msg.ToUpper());
		}
	}
}
