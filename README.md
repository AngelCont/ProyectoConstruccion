# Proyecto de Construcción

# Sangria y espaciamiento

1. Para la sangria seran utilizados los TAB, no los espacios

2. Las llaves "{ }" estarán al mismo nivel del código

  Ejemplo correcto:
  ```csharp
  bool metodoEjemplo()
    {
      //Instrucciones
      //...
    }
  ```

  Ejemplo incorrecto
  ```csharp
  bool metodoEjemplo(){
    //Instrucciones
    //...
  }
  ```
3. Para separar un grupo lógico de código, utiliza una línea en blanco

  Ejemplo correcto
  ```csharp
  bool metodoEjemplo()
    {
      String mensaje = "Hola " + nombreEmpleado;
      String MensajeCompleto = mensaje + ", hoy debes realizar " + metaDiaria;

      messageBox(MensajeCompleto);  
      //Instrucciones
      //...
    }
    ```

  Ejemplo incorrecto
  ```csharp
  bool metodoEjemplo()
    {
      string mensaje = "Hola " + nombreEmpleado;
      string MensajeCompleto = mensaje + ", hoy debes realizar " + metaDiaria;
      -----------------------------------------------------------------------
      messageBox(MensajeCompleto);  
      //Instrucciones
      //...
    }
    ```

4. Entre cada método de una clase solo debe haber una línea en blanco de separación

5. Uso de #region para agrupar piezas de codigo juntas

  Ejemplo:
  ```csharp
  #region
  
    bool entradaValidada = false;
    string metaDiaria;
  #endregion
  ```

6. Mantener privadas las variables globales, las propiedades y los métodos en la parte superior del archivo y los elementos públicos en la parte inferior
