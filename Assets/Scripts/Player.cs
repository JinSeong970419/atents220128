using System.Collections;           //���ӽ����̽� ����(C# �����̳ʿ�)
using System.Collections.Generic;   //���ӽ����̽� ����(C# �����̳ʿ�, ���׸�)
using UnityEngine;                  //���ӽ����̽� ����(Unity ��)
using UnityEngine.;                  //unity �� ��ǲ �ý����� ���� ���� ���ӽ����̽�


/// ���������� : public(����, ������), protected(��ȣ��), private(��������)
/// public : ������ �� �� �ִ�.
/// private : ������ �ִ� �ڸ� �� �� �ִ�. C# ����Ʈ
/// protected : ���� ���� ��ӹ��� �ڸ� �� �� �ִ�.
/// Ű���� : C#���� ����� ������ ���� �ܾ��(�Ķ������� ���̴� �κе�)
/// class : ������ Ʋ. � ����� �ϰ� � �����͸� ���� �� �ִ��� ������ ���� ������ ���赵
/// ��ü : Ŭ������ �ν��Ͻ� �� ��.Ŭ������ ��üȭ �� ��
/// ���� : �����͸� �����ϴ� ��. ������ Ÿ��

//class MyTest
//{

//}

//Player��� �̸��� Ŭ������ ����µ� public�̶� ���α׷� ���� ��ΰ� ������ �� �ְ�
//MonoBehaviour��� Ŭ������ ��ӹ޾Ҵ�.
public class Player : MonoBehaviour
{
    // jumpPower��� �̸��� float Ÿ���� ������ ����µ�. public�̰� ����Ǵ� �ʱⰪ�� 10.0�̴�.
    public float jumpPower = 10.0f;
    // rigid��� �̸��� Rigidbody2D Ÿ���� ������ ����µ�, private�̰� ����Ǵ� �ʱⰪ�� null�̴�.
    private Rigidbody2D rigid = null;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    //private void Update()
    //{
    //    // Input Manager
    //    //if (Input.GetButton("Jump"))
    //    //{
    //    //    rigid.AddForce(Vector2.up * jumpPower);
    //    //}
    //    //if(Input.GetKeyDown(KeyCode.Space))
    //    //{

    //    //}
    //}

    // �����̽� ��ư�� ������ �� �����  �Լ�
    // ����� RigidBody�� ���� �������� ���� ���Ѵ�.
    public void JumpUp(InputAction.callbackContext context)
    {
        rigid.AddForce(Vector2.up * jumpPower);
    }
}
