#Notacion para el nombramiento de variables

1.- Notacion Camell: El primer caracter de las palabras se escribe en mayuscula (Exceptuando la primer palabra) y los demas caractereres se escriben en minusculas.

      Forma correcta: variablesLocales.
      Forma Incorrecta: VariablesLocales.

1.1- Usa la notacion Camell para el nombramiento de variables.

    int Saldo.

2.-Usa palabras entendibles y descriptivas para nombrar a las variables. NO uses abreviaciones.

      Forma correcta: string dirección;
                    int salario;

      Forma incorrecta: string nom;
                      string domic;
                      int sal;

#Notacion para el nombramiento de clases.

1.- Notación Pascal: El primer caracter de todas las palabras se escriben en mayusculas, los demas caracteres se escriben en minusculas.

      Forma correcta: NombreDeLaClase.
      Forma Incorrecta: nombreDelaClase.

1.1.- Usa notacion Pascal para el nombre de las clases.

    Public class HolaMundo
    {
        ...
    }

#Notacion para el nombramiento de metodos.

1.- Utiliza notación Pascal para el nombramiento de los metodos.

      Forma correcta:
      void SumarPuntos(int puntos)
      {
        ...
        ...
      }

      Forma incorrecta:
      void sumarPuntos(int puntos)
      {
        ...
        ...
      }

2.-Usa notación de Camell para variables y parámetros de los métodos.

Ejemplo:

int cuentaTotal = 0;
void DiHola(string nombre)
{
  string mensajeCompleto = “Hola “ + nombre;
  ...
}

Usa el prefijo “I” con notaciónPascal para las interfaces
(Ejemplo: IEntity).

Utiliza “T“ para estructuras de tipos de datos.

publicclassTFactura
{
  public String NombreDelCliente;
  (...)
  public ArrayList LineasDeDetalle= newArrayList();
}

3.-No uses notación Húngara para el nombre de las variables.

4.-La función Húngara –la  cual especifica el tipo de dato de la variable como un prefijo en el nombre y utliza el prefijo m_ para variables globales.

Ejemplo: string m_sNombre;
         int nEdad;

5.-El  uso  del tipo de dato y del prefijo m_ para representar variables globales no debeser usado. Todas las variables deben usar una notación Camell.

6.-No uses nombres de variables de un solo caracter como i, n, s, etc.
Usa nombres como indice, temp.

7.-Una excepciónen este caso podría ser las variables usadas para iteraciones en los ciclos:

for ( int i = 0; i < cuantos; i++)
{
  ...
}

8.-No uses guiones bajos ( _ ) para nombres de variables locales.

9.-Todas  las variables globalesdeben  usar  el  prefijo  de  guión  bajo  ( _ )  de  tal  forma  que puedan ser identificadas de otras variables locales.

10.-No uses palabras reservadas para nombres de variables.

11-Escriba solo una declaración por línea.

12.-Si las líneas de continuación no están sangradas automáticamente, sangra una tabulación (cuatro espacios).

13.-Agregue al menos una línea en blanco entre las definiciones de métodos y las definiciones de propiedades.

14.-Use paréntesis para hacer que las cláusulas en una expresión sean aparentes, como se muestra en el siguiente código.

if ((val1 > val2) && (val1 > val3))
{
    // Codigo
}

# Proyecto de Construcción

Utilizando el estandar .NET de Microsoft como base este es el estandard de codificación que rige este proyecto:

## Definición de comentarios

- Los comentarios se ponen después de dos diagonales: //
- Los comentarios demasiados largos (más de 100 carácteres) se continuan en la siguiente línea
- No debe ser comentado así: /\*...*/

_Buen comentario_

~~~ c#
//Este es un comentario bien escrito.

//Este comentario también esta bien redactado pero es demasiado largo
//por eso se continua en otra linea.
~~~

__Mal comentario__

~~~ c#
/* Mal Comentario */

/*
 * Mal Comentario
 */
~~~

- Los comentarios deben iniciar con mayúscula
- Terminar los comentarios con un punto

_Buen comentario_

~~~ c#
//Buen comentario.
~~~

__Mal comentario__

~~~ c#
//mal comentario
//Mal comentario
~~~

- Los comentarios se ponen una línea arriba de donde está lo que se quiere comentar
- Nunca comentar al finalizar la línea de código

_Buen comentario_

~~~ c#
//Verifica que el valor de la lista coincida con el número de personas.
if(lista.getValor(i) == personas.getCantidad())
{
    //Resto de codigo.
}
~~~

__Mal comentario__

~~~ c#
if(lista.getValor(i) == personas.getCantidad()) //Verifica que los valores coincidan
{
    //Resto de codigo.
}
~~~

- Los comentarios deben ser cortos y claros
- No debe haber comentarios que no tienen que ver con el código
- No se debe comentar todas las variables declaradas

_Buen comentario_

~~~ c#
//Actualiza el cálculo automáticamente.
~~~

__Mal comentario__

~~~ c#
// le toca a ver esto a Juan

int animal; //Numero de perros registrados en los estados transitados.
~~~

## Documentación de clases y métodos

C# utiliza XML para generar la API del proyecto

- Los comentarios utilizados para la documetación de clases y métodos usan tres barras diagonales: /// y un cuerpo de comentario con formato XML. Por ejemplo:

Ejemplo:

~~~ c#
/// <summary>
/// Esta clase hace algo.
/// </summary>
public class AlgunaClase
{

}
~~~

- La documentación generada a partir de los comentarios de tres barras diagonales no incluye aquellos comentarios dejados despues dos barras diagonales: //

La base para la documentación de una clase cualquiera en este proyecto es:

~~~ c#
/// <summary>
/// Explicación general de la clase.
/// </summary>
/// <remark>
/// Explicación poco mas detallada de clase.
/// </remark>
/// 
public class AlgunaClase
{

}
~~~

La base para la documentación de un método cualquiera en este proyecto es:

~~~ c#
/// <summary>
/// Explicación general del metodo.
/// </summary>
/// <remark>
/// <para>Explicación mas detallada del metodo.</para>
/// </remark>
/// <param name="nombre de parametro">Tipo de parametro.</param>
/// <returns>
/// Aclaración de valor que regresa.
/// </returns>
/// <exception cref="excepción">Condición para aparición de la excepción.</exception>
private void multiplicar(int ancho, int alto)
{

}
~~~

No todos los métodos utilizan esas etiquetas, si no utilizas una quítala y continua con la siguiente. En caso de que quiera usar otra etiqueta el orden es el siguiente:

~~~ c#
/// <value>
/// <example>
/// <code>
/// <typeparam>
/// <paramref>
/// <typeparamref>
/// <list>
/// <see>
/// <seealso>
~~~

### Etiquetas

Las etiquetas que se pueden realizar están redactadas en la web .NET de Microsoft, puede verlas [aquí](<https://docs.microsoft.com/es-es/dotnet/csharp/codedoc> "Documentar el código con comentarios XML")
