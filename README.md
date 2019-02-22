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