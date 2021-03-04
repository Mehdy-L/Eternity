using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    [SerializeField]
    private float mouseSensitivityX = 3f;

    [SerializeField]
    private float mouseSensitivityY = 3f;

    private PlayerMotor motor;

    private void Start()
    {
        //Récuperer le script PlayerMotor
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        // Calculer la vélocité (vitesse) du mouvement de notre joueur
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMove;
        Vector3 moveVertical = transform.forward * zMove;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);

        //On calcule la rotation du joueur en un Vector3
        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensitivityX;

        motor.Rotate(rotation);

        //On calcule la rotation du joueur en un Vector3
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 camerarotation = new Vector3(xRot, 0, 0) * mouseSensitivityY;

        motor.RotateCamera(camerarotation);
   }
}
