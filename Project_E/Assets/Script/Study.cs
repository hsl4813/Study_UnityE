using UnityEngine;

public class Study : MonoBehaviour
{
    
    public string say = "";
    public char text = 'a';
    public int var01 = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;
    
    void Start()
    {
        //Debug.Log("Hello World!");
        int neVar = 10;
        Debug.Log(neVar);
        Debug.Log(this.say);
        Debug.Log(this.text);
    }

   
    void Update()
    {
        
    }
}
