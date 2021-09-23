using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneOneClick : MonoBehaviour
{
    public int numberOfClones = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        //Vie
        //Destroy(gameObject);

        //La vie !
    for (int i = 0; i < numberOfClones; i = i + 1) {
            GameObject toto = Instantiate(gameObject);
            Destroy(toto, 6f);
        }
}
}