![image](https://github.com/user-attachments/assets/7f9ed7bd-b51d-44f1-890e-39edd0d38437)

# Hangmang en C# - Proyecto Final Estructuras de Datos y Algoritmos

## Descripción
Esta es una implementación simple del juego de Ahorcado en C#. El juego consiste en adivinar una palabra oculta sugiriendo letras. Cada intento incorrecto reduce el número de vidas disponibles. El juego termina cuando se adivina la palabra correctamente o cuando el jugador se queda sin vidas.

## Estructura del Juego
El juego está implementado en varias partes:

1. **Program.cs**: Punto de entrada principal para el juego que inicia el ciclo del juego.
2. **Game.cs**: Contiene la lógica del juego, como gestionar la palabra, comprobar los intentos y hacer el seguimiento de las vidas.
3. **WordManager.cs**: Se encarga de la selección aleatoria de palabras de una lista predefinida.
<!-- 4. **GameTests.cs**: Pruebas unitarias para verificar la corrección de la lógica del juego. -->

## Estructuras de Datos Usadas
- **List**: Para almacenar las letras adivinadas.
- **String**: Para almacenar la palabra secreta.
- **Integer**: Para hacer el seguimiento del número de vidas.

## Características Adicionales
- Selección aleatoria de palabras de una lista.
- Muestra de las letras adivinadas y las vidas restantes.
- Manejo simple de errores para entradas no válidas.

## Cómo Ejecutar
1. Clonar o descargar el repositorio.
2. Abrir la solución `.sln` en Visual Studio.
3. Construir y ejecutar `Program.cs`.

## Mejoras Futuras
- Añadir niveles de dificultad con diferentes listas de palabras.
- Implementar pistas y puntuaciones basadas en el tiempo y las vidas usadas.

## Licencia
Este proyecto está licenciado bajo la Licencia MIT.
