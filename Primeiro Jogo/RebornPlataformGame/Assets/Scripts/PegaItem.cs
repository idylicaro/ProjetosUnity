using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaItem : MonoBehaviour
{
    public GameObject particula;
    public Color cor;
    GameObject objetoPrincipal;
    
    // Start is called before the first frame update
    void Start()
    {
        objetoPrincipal = GameObject.Find("GameEngine");
    }

    // Update is called once per frame
    // verifica se este item ta tocando o personagem  //parametro o outro objeto que ele colidiu
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            switch (this.gameObject.tag)
            {
                case "Ovo": objetoPrincipal.SendMessage("pegaovosound"); objetoPrincipal.SendMessage("pegaOvo"); ; break;
                case "Pena": objetoPrincipal.SendMessage("pegaPenasound"); objetoPrincipal.SendMessage("pegaPena"); break;
                case "Estrela": objetoPrincipal.SendMessage("pegaEstrela"); break;
                case "Fogo": objetoPrincipal.SendMessage("efeitoLevouDano"); print("opa"); break;
                case "Finish": objetoPrincipal.SendMessage("caiNoBuraco"); print("opa"); break;
                default : break;

            }
        }
        if(particula != null)
        {
            GameObject minhaParticula = Instantiate(particula);
            minhaParticula.transform.position = this.transform.position;  // reposiciona a particula na msm posição do item 
            minhaParticula.GetComponent<ParticleSystem>().startColor = cor;
            Destroy(this.gameObject);
        }
        
    }
}
