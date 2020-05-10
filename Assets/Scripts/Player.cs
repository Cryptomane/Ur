using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private bool privateBool;
    [SerializeField]
    private float privateFloat;
    [SerializeField]
    private string privateString;

    // Read-only accessor Property
    public bool PrivateBool
    {
        // Reading access
        get
        {
            return privateBool;
        }
        // Writing access
        private set
        {
            privateBool = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
