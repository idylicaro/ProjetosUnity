using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Principal : MonoBehaviour
{
    public GameObject jogador;
    public Image heart;
    public Text vidasRestante;
    public Text itemsTxt;
    public Text TextWin;
    public GameObject loseSound;
    public GameObject winSound;

    int ovos;
    int penas;
    int itemsTotal;
    int vidas = 3;
    int contaPisca = 0;
    GameObject cuboVidro;

    // Start is called before the first frame update
    void Start()
    {
        cuboVidro = GameObject.Find("VidroBlock");

        //pegando informações sobre quantidade de items
        GameObject[] listaDeOvos = GameObject.FindGameObjectsWithTag("Ovo");
        GameObject[] listaDePenas = GameObject.FindGameObjectsWithTag("Pena");
        ovos = listaDeOvos.Length; 
        penas += listaDePenas.Length;
        itemsTotal = ovos+penas;

        //atualizando text
        itemsTxt.text = "Items:" + itemsTotal.ToString();
        vidasRestante.text = vidas.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void pegaOvo() {
        itemsTotal--;
        if (itemsTotal <= 0)
        {
            PegouTodosOsItems();
          
        }
        itemsTxt.text = "Items:" + itemsTotal.ToString();
    }
    public void pegaPena() {
        itemsTotal--;
        if (itemsTotal <= 0)
        {
            PegouTodosOsItems();

        }
        itemsTxt.text = "Items:" + itemsTotal.ToString();
    }
    public void pegaEstrela() {
        TextWin.text = "PARABÉNS ^-^";
        
        winSound.GetComponent<AudioSource>().Play();
    }
    public void efeitoLevouDano() {
        vidas--;
        if (vidas <= 0) {
            vidas = 0;
            gameOver();
        }
        vidasRestante.text = vidas.ToString();
        InvokeRepeating("piscaPlayer", 0, 0.15f);
        jogador.transform.position = new Vector3(-0.478f, -10.372f, -20.04f);
        

    }
    public void caiNoBuraco() {
        efeitoLevouDano();
        //jogador.transform.position = new Vector3(-0.478f, -10.372f, -20.04f);
        //Invoke("recarregaCena", 1.5f);
    }

    public void PegouTodosOsItems() {
        cuboVidro.SetActive(false);
    }

    public void gameOver() {
        TextWin.text = "Perdeu :(";
        loseSound.GetComponent<AudioSource>().Play();
        sleep();
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
    }

    [System.Obsolete]
    public void recarregaCena()
    {
        Application.LoadLevel("fase1");
    }
    public void piscaPlayer()
    {
        contaPisca++;
        jogador.SetActive(!jogador.activeInHierarchy);

        if(contaPisca > 5)
        {
            contaPisca = 0;
            jogador.SetActive(true);
            CancelInvoke("piscaPlayer");
        }
    }
    IEnumerator sleep()
    {
        yield return new WaitForSeconds(10f);
        print("esperando");
    }
}
