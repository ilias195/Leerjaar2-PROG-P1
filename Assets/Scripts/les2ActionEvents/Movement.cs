using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{

    private float _hInput;
    private float _vInput;
    [SerializeField] float speed;


    private void Update()
    {
        _hInput = Input.GetAxisRaw("Horizontal");
        _vInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(_hInput, 0f, _vInput) * speed * Time.deltaTime;
        
        
        transform.position += movement;
        
    }

}
