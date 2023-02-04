using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlManager : MonoBehaviour
{

    public string web1;
    public string web2;
    public string web3;
    public string web4;
    public string web5;
    public string web6;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void youtube ()
    {
        Application.OpenURL(web1);
    }

    public void W3School ()
    {
        Application.OpenURL(web2);
    }

    public void Cisco ()
    {
        Application.OpenURL(web3);
    }

    public void Udemy()
{
    Application.OpenURL(web4);
}

        public void unity()
        {
            Application.OpenURL(web5);
        }

        public void UdeGVirtual()
        {
            Application.OpenURL(web6);
        }


    }
