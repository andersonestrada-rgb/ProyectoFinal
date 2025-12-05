using System.IO;
using UnityEngine;

// La línea "using static UnityEditor.Experimental.GraphView.GraphView;" FUE ELIMINADA

public class OH : MonoBehaviour
{
    private PlayerController player;
    private bool infected = false;

    void Start()
    {
       
        GameObject obj = GameObject.FindGameObjectWithTag("Player");

        // Chequeo de GameObject
        if (obj == null)
        {
            Debug.LogError($"'{gameObject.name}' (Script OH) - No encontré un objeto con el tag 'Player'. Deshabilitando script.");
            enabled = false;
            return;
        }

        // Obtener el componente PlayerController
        player = obj.GetComponent<PlayerController>();

        if (player == null)
        {
            Debug.LogError($"'{gameObject.name}' (Script OH) - El objeto 'Player' no tiene el componente 'PlayerController'. Deshabilitando script.");
            enabled = false;
            return;
        }

        print("Objeto Player encontrado y PlayerController obtenido.");
        print(player.GetLifePlayer());
    }


    void Update()
    {
        // Verifica si el jugador existe, su vida es <= 0, y no ha sido "infectado" aún
        if (player != null && player.GetLifePlayer() <= 0 && !infected)
        {
            CreateTextFile();
            infected = true;
        }
    }

    void CreateTextFile()
    {

        string desktopPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop); // Ruta del escritorio del usuario
        string filePath = Path.Combine(desktopPath, "OH.txt");

        // Arte ASCII incluido como string literal
        string doroImagen =
/* (El arte ASCII ha sido omitido por brevedad en la respuesta, pero debería estar aquí) */
@"
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                          -##+--------+#####.      ..--.                                          
                                    -#+---##+----+##------##--###+----+#####-                                     
                                  +#----++####-+###+##+-----+#+------#+---+#-+#                                   
                                -#-----##--##---##----+#------#+----#+---#+-##-#                                  
                              .#-----#----+-------+-----#+.----+#---#--#####-+#-#                                 
                             .#--..+#--------...--------.#+..----#--#-#-#--###+##                                 
                            -#--..++..------.....-------..#-.-----#-##+-+###+#####++##                            
                           ++---.++..---+---.....----#---..#.------#-+#+--#######   .#                            
                          #------#..---#-----..------+#-----#------#+---+####++#+.  -+                            
                        .#------#-----#+----------#---#-----#-------#----+++######.-##                            
                      .#+-------#----#.#----------#--+#------+------##############   +.                           
                    #+---#-----#---###.#---+#-----#--#.#-----#------+##+########.++ -+                            
                        .#-----#--+##+-##+--#----#+--#..-#---#-------#-++-#+###+##-####.                          
                        .------#+###+++++##++#---#############-------#----#+#.-##.  #..##.                        
                        ------##..#+++++++######+###+##.###..#-------#----#++#     #-   +#-                       
                        .+--+#....-#-....-#.     . -#+++++##.#-------#---++#+.    #-     +#.                      
                        .#--#.......#####.         +++++++-##+------+#---# .#    #.       #+                      
                         #--#..........  ..        .#--...-##-------#+--#.  #. .#         ##                      
                         .+-+#.......... ++.-##...   ##+##-#--------#-+#     # #.         ##                      
                          #---#+.......   ... ...   ......#+-------###.      .#.          ##                      
                          .#-----##...              ....-#--+#----##.                     ##                      
                           .#------#-+###++---...--++######-#+---++                      .#-                      
                            .#--##--#                      .#---#-                       #+                       
                              -###-###                    +#--+#.            +#.       -#+                        
                                ##.    .                -#-+##.            .##.       ##.                         
                                 #+    ###.                              -###-       ##                           
                                 -#.    -####.                        +##- +#       .#+                           
                                  ##.    +#..+#####-            .#####-    +#        ##                           
                                   ##.   +#.      ##           ##           ##       -#.                          
                                    -##-+#+       .##          ##            ##      +#                           
                                       ..           ##.        ##             ##-   ##-                           
                                                     .##.      ##              .####-                             
                                                       .####+##+                                                  
                                                            .                                                     
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
                                                                                                                  
";

        try
        {
            File.WriteAllText(filePath, doroImagen); // Crea el archivo
            print("¡Infectado! Archivo OH.txt creado en el escritorio.");
        }
        catch (System.Exception e)
        {
            // Es buena práctica capturar posibles errores de IO/permisos
            Debug.LogError($"Fallo al crear el archivo en: {filePath}. Error: {e.Message}");
        }
    }
}