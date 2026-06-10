using UnityEngine;
public class GamaManager : MonoBehaviour { // MonoBehaviour implementa o comportamento basico de um objeto da unity
    public static GamaManager gameManager; 
    // Como esse script vai ser anexado em um objeto, na unity se costuma guardar a variavel do
    // singleton no proprio script

    // Variaveis =======================
    public int Pontos;
    public int Vidas;
    public int Fase;
    public float VolumeMusica;
    public float VolumeSFX;
    //===================================

    // O metodo Awake he do MonoBehaviour
    // Ele executa uma vez quando o objeto he iniciado
    // Nesse caso ele esta servindo como um construto para o singleton
    void Awake() { 
        if(gameManager == null) { // Verifica se a variavel gameManager ja foi iniciada
            gameManager = this; // adiciona o proprio singleton na variavel
            DontDestroyOnLoad(gameObject); // Marca o GameObject que tem esse script como DontDestroyOnLoad, assim ele continua na proxima scena
        }
        else { 
            Destroy(gameObject); // Como ja existe uma instancia do gameManager, esse novo objeto com esse script vai ser destruido
        }

        //Metodos para carregar dados
    }

    // Sobre a Unity =======================
    /*
    O sistema da unity funciona com GameObjecs dentro de uma scena.
    Dentro de um GameObject existe componentes que sao scripts que herdao MonoBehaviour.
    O GameManager 'e um GameObject que contem esse Script, o Singleton, e tambem vai estar em todas as Scenas (Para nao der erro quando tentar executar uma scena fora de ordem).
    Na maioria dos casos vao ter 2 GamaManager na mesma scena, um que veio da scena anterior e ja esta marcado com o DontDestroyOnLoad, e o outro que foi inicializado na scena atual.
    Quando a scena For executa, o Awake do novo GameManager vai ser executado, e se ja tiver alguma instancia na variavel gamaManager, ele vai destruir o GameObject, caso contrario vai atribuir o script como o gameManager.
    Detalhe que quando o GameManager ele ja vem de outra scena marcado como DontDestroyOnLoad, ele nao vai executar o Awake, por que ele ja executou o awake na scena anterior.
    */
    //======================================


    // Metodos de load e salvamento NAO RELEVANTES AO SINGLETON MAS FAZEM PARTE DO GAMEMAGER
    //Exemplo
    /*
    public void SaveConfig() {
        String pathConfig = Application.persistentDataPath + "/config.json";

        ConfigData configData = new ConfigData {
            Volume = this.Volume
        };

        String json = JsonUtility.ToJson(configData);

        File.WriteAllText(pathConfig, json);
    }
    public void LoadConfig() {
        String pathConfig = Application.persistentDataPath + "/config.json";

        if (File.Exists(pathConfig)) {
            String json = File.ReadAllText(pathConfig);
            ConfigData configData = JsonUtility.FromJson<ConfigData>(json);

            Volume = configData.Volume;
        }
    }
    */
}
