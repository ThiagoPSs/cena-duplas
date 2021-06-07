using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov2 : MonoBehaviour
{

	public float speed = 12f;
	public float gravidade = 9.81f;
	public float alturapulo = 3f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	bool isLeftButtonDown;
	bool isRightButtonDown;
	bool isMiddleButtonDown;
	Renderer rend;
	Vector3 m;
	public Vector3 rotateChange;
	public Vector3 rotateChange2;
	public Vector3 positionChange;

	Vector3 velocidade;
	bool isGrounded;

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocidade.y < 0)
		{
			velocidade.y = -2f;
		}
		float o = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * o + transform.forward * z;

		if (Input.GetButtonDown("Jump") && isGrounded) ;
		{
			velocidade.y = Mathf.Sqrt(alturapulo * -2f * gravidade);

		}

		velocidade.y += gravidade * Time.deltaTime;


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
					m.x = 0.0f * speed;


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


		}
	}
}
