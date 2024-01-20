using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    Vector3 velocity; // Yer çekimini ayarlamak için velocity adýnda deðiþken tanýmladýk.
    bool isGrounded; // Karekter yerdemi sorugusu yapmak için float tipinde deðiþken tanýmladýk.

    public Transform ground;
    public float distance = 0.3f; // Karakterin yerden olan yüksekliðini belirttik.

    public float speed; // Karakterimizin hýzý.
    public float jumpHeight; // Zýplama gücü.
    public float gravity; // Etkileneceði yer çekiminin miktarýný belirttik.

    public LayerMask mask; // Mask adýnda bir layer maskesi tanýmladýk.

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        // Oyun baþlayýnca objemizde bulunan CharacterController component'ýný controller olarak tanýmlýyoruz.
    }

    private void Update()
    {

        // Hareket Kodlarýmýz
        float horizontal = Input.GetAxis("Horizontal"); // Sað sol hareketleri için horizontal yani x eksenini alýyoruz.
        float vertical = Input.GetAxis("Vertical"); // Ýleri geri hareketleri için vertical yani z eksenini alýyoruz.

        Vector3 move = transform.right * horizontal + transform.forward * vertical; // move vectorümüzün ileri geri ve sað sol yönünü ayarlýyoruz.
        controller.Move(move * speed * Time.deltaTime); // Karakterimizin hareketini move vectöründe belirlediðimiz speed kadar ilerletiyoruz.



        // Zýplama Kodlarýmýz
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) // Eðer karekterimiz yere deðiyorsa ve deðerken 'Space' tuþuna basarsa.
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity); // 
        }



        // Yer Çekimi Kodlarýmýz
        isGrounded = Physics.CheckSphere(ground.position, distance, mask); // Kürenin merkezini ground.position noktasýný kullanýyoruz.
                                                                           // Kürenin yarý çapý için distance deðiþkenini kullanýyoruz.
                                                                           // Kürenin hangi layer ile çarpýþtýðýný kontrol edeceðini ayarlýyoruz.
                                                                           // Bu þartlara göre eðer kürenin çevresinde baþka bir nesne varsa true, yoksa false döner.

        if (isGrounded && velocity.y < 0) // Eðer karakter yere deyiyorsa ve dikey eksendeki hýz 0 dan küçük ise yani yukarý veya aþaðý doðru hareket etmiyorsa.
        {
            velocity.y = 0f; // Yer çekimini 0 yap.
        }

        velocity.y += gravity * Time.deltaTime; // velocity'nin y eksenine gravity kadar ekle
        controller.Move(velocity * Time.deltaTime); // Karakterimizi velocity kadar hareket ettir.
    
    }
}