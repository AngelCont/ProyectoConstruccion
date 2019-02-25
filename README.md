# Proyecto de Construcción

## Nombramiento de variables

- Notacion CamelCase: El primer caracter de las palabras se escribe en mayuscula (exceptuando la primer palabra) y los demas caractereres se escriben en minuscula.
- Usa la notacion Camell para el nombramiento de variables.

~~~ c#
//Forma correcta:
int variablesLocales
int saldo

//Forma incorrecta:
int VariablesLocales.
string NombrePersonal
~~~

- Usa palabras entendibles y descriptivas para nombrar a las variables. __NO uses abreviaciones__.

~~~ c#
//Forma correcta:
string dirección;
int salario;

//Forma incorrecta:
string nom;
string domic;
int sal;
~~~

## Nombramiento de clases

- Notación Pascal: El primer caracter de todas las palabras se escriben en mayusculas, los demas caracteres se escriben en minusculas.
- Usa __unicamente__ notacion __Pascal__ para nombrar las clases

~~~ c#
//Forma correcta:
public class NombreDeLaClase{

}

public class HolaMundo{
  ...
}

//Forma Incorrecta:
public class nombreDelaClase{

}

public class holaMundo{
  ...
}
~~~

## Notacion para el nombramiento de metodos.

- Utiliza notación CamelCase para el nombramiento de los metodos.

~~~ c#
//Forma correcta:
void sumarPuntos(int puntos)
{
  ...
  ...
}

//Forma incorrecta:
void SumarPuntos(int puntos)
{
  ...
  ...
}
~~~

- __Usa notación de CamelCase para variables y parámetros de los métodos.__

Ejemplo:

~~~ c#
int cuentaTotal = 0;
void diHola(string nombre)
{
  string mensajeCompleto = “Hola “ + nombre;
  ...
}
~~~

- Usa el prefijo “I” con notación Pascal para las interfaces

~~~ c#
//Ejemplo: 
IEntity
~~~

- Utiliza “T“ para estructuras de tipos de datos.

~~~ c#
public class TFactura
{
  public String nombreDelCliente;
  (...)
  public ArrayList lineasDeDetalle= newArrayList();
}
~~~

- __No__ usar notación Húngara para el nombre de las variables (Que codificas a gusto personal).

- __Tampoco__ usar la función Húngara –la  cual especifica el tipo de dato de la variable como un prefijo en el nombre y utliza el prefijo m_ para variables globales.

~~~ c#
//Ejemplo:
string m_sNombre;

int nEdad;
~~~

- El uso del tipo de dato y del prefijo m_ para representar variables globales no debe ser usado. Todas las variables deben usar una notación CamelCase.

- No uses nombres de variables de un solo caracter como i, n, s, etc.
Usa nombres como indice, temp.

- Una excepción en este caso podría ser las variables usadas para iteraciones en los ciclos:

~~~ c#
for ( int i = 0; i < cuantos; i++)
{
  ...
}
~~~

- No uses guiones bajos ( _ ) para nombres de variables locales.

- Todas las variables globalesdeben usar el  prefijo de guión bajo ( _ ) de tal forma que puedan ser identificadas de otras variables locales.

- No uses palabras reservadas para nombres de variables.

- Escriba solo una declaración por línea.

- Si las líneas de continuación no están sangradas automáticamente, sangra una tabulación (cuatro espacios).

- Agregue al menos una línea en blanco entre las definiciones de métodos y las definiciones de propiedades.

- Use paréntesis para hacer que las cláusulas en una expresión sean aparentes, como se muestra en el siguiente código.

~~~ c#
if ((val1 > val2) && (val1 > val3))
{
    // Codigo
}
~~~

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
