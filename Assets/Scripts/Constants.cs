using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    
    /* En esta clase se definen las constantes a usar dentro del juego. Es importante definirlas
     * desde un solo lugar para cuando se requiera hacer un cambio global y una variable se use en muchos
     * scripts, no sea necesario ir cambiando uno por uno sino solo el valor desde aqui */

    public const int CherryHealthRecovery = 10;



    /*Parametros de Objetos Coleccionables/Recogibles*/

    public enum Pickable{ Emerald, Gem, Cherry};

}
