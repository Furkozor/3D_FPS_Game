using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    Vector3 velocity; // Yer �ekimini ayarlamak i�in velocity ad�nda de�i�ken tan�mlad�k.
    bool isGrounded; // Karekter yerdemi sorugusu yapmak i�in float tipinde de�i�ken tan�mlad�k.

    public Transform ground;
    public float distance = 0.3f; // Karakterin yerden olan y�ksekli�ini belirttik.

    public float speed; // Karakterimizin h�z�.
    public float jumpHeight; // Z�plama g�c�.
    public float gravity; // Etkilenece�i yer �ekiminin miktar�n� belirttik.

    public LayerMask mask; // Mask ad�nda bir layer maskesi tan�mlad�k.

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        // Oyun ba�lay�nca objemizde bulunan CharacterController component'�n� controller olarak tan�ml�yoruz.
    }

    private void Update()
    {

        // Hareket Kodlar�m�z
        float horizontal = Input.GetAxis("Horizontal"); // Sa� sol hareketleri i�in horizontal yani x eksenini al�yoruz.
        float vertical = Input.GetAxis("Vertical"); // �leri geri hareketleri i�in vertical yani z eksenini al�yoruz.

        Vector3 move = transform.right * horizontal + transform.forward * vertical; // move vector�m�z�n ileri geri ve sa� sol y�n�n� ayarl�yoruz.
        controller.Move(move * speed * Time.deltaTime); // Karakterimizin hareketini move vect�r�nde belirledi�imiz speed kadar ilerletiyoruz.



        // Z�plama Kodlar�m�z
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) // E�er karekterimiz yere de�iyorsa ve de�erken 'Space' tu�una basarsa.
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity); // 
        }



        // Yer �ekimi Kodlar�m�z
        isGrounded = Physics.CheckSphere(ground.position, distance, mask); // K�renin merkezini ground.position noktas�n� kullan�yoruz.
                                                                           // K�renin yar� �ap� i�in distance de�i�kenini kullan�yoruz.
                                                                           // K�renin hangi layer ile �arp��t���n� kontrol edece�ini ayarl�yoruz.
                                                                           // Bu �artlara g�re e�er k�renin �evresinde ba�ka bir nesne varsa true, yoksa false d�ner.

        if (isGrounded && velocity.y < 0) // E�er karakter yere deyiyorsa ve dikey eksendeki h�z 0 dan k���k ise yani yukar� veya a�a�� do�ru hareket etmiyorsa.
        {
            velocity.y = 0f; // Yer �ekimini 0 yap.
        }

        velocity.y += gravity * Time.deltaTime; // velocity'nin y eksenine gravity kadar ekle
        controller.Move(velocity * Time.deltaTime); // Karakterimizi velocity kadar hareket ettir.
    
    }
}