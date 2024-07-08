# 2024-1 Examen de Recuperacion de Desarrollo de Videojuegos con Motores

## Instrucciones Generales del Examen:
El examen consta de desarrollar un videojuego implementando las funcionalidades solicitadas.

No se puede usar Assets o codigos previamente desarrollados. No se puede implementar funcionalidades o configuraciones realizadas por terceros.

El examen se debe desarrollar en branches individuales (ApellidoNombre). Se debe tener al menos 4 Commits con avances del examen.

Recordatorio: El examen es presencial y personal. Se debera compartir la pantalla donde se está desarrollando el examen.


## Instrucciones Especificas del Examen (Habilitadas a las 3:00 pm UTC -5)

Se debe desarrollar un videojuego de Infinity Runner donde el jugador deberá obtener el mayor puntaje posible esquivando enemigos y recolectando dulces. El minijuego es sencillo, pero debe estar los más pulido y presentable posible, además de ser escalable.

* **Reglas del Videojuego:**
    1) El jugador controla un personaje que solo se mueve verticalemnte (hacia arriba y abajo).
    2) El jugador puede interactuar con 2 tipos de objetos: los obstáculos (4 diferentes) y los dulces (4 diferentes) que se mueven desde la parte de la derecha a la izquierda de la pantalla.
    3) El jugador posee 3 vidas, las cuales se les van descontando conforme colisione con otros enemigos en el mapa. Cuando el jugador pierda, su puntaje actual se guardará y mostrará en la pantalla de RESULTADOS.
    4) El jugador obtiene puntaje mientras sigue jugando y puede obtener puntos extras al recolectar los dulces.
    5) El juego debe contar con 3 pantallas: MENU, JUEGO y RESULTADOS.
    6) La Pantalla de MENU es para jugar, salir del juego, o configurar los sonidos (ON/OFF). La Pantalla JUEGO debe contener el minijuego y la GUI del juego así como configuración de sonido (ON/OFF). La Pantalla de RESULTADOS debe mostrar los puntajes y regresar al MENU.

* **Requerimientos del Videojuego:**
    1) El personaje se debe poder mover utilizando el nuevo Input System y actualizar los controles: W/Arriba para subir y S/Abajo para bajar. (1 punto).
    2) Debe haber un Generador de Enemigos. Los Enemigos deben movese a la izquierda y se destruyen al colisionar con el jugador o salir de la pantalla. Se debe integrar al menos 4 tipos de Enemigos con diferntes características. (2 puntos)
    3) Debe haber un Generador de Dulces. Los Dulces deben movese a la izquierda y se destruyen al colisionar con el jugador o salir de la pantalla. Se debe integrar al menos 4 tipos de Ducles con diferntes características. (2 puntos)
    4) En JUEGO debe haber una UI que muestra y actualiza la Vida del Jugador y su Puntaje Actual. Además, debe tener 2 botones de ON/OFF para el audio de Música y Sonido. (2 Puntos).
    5) En RESULTADOS se debe mostrar el Puntaje Actual del jugador, mostrar si obtuvo la Puntuación Máxima y mostrar los 10 mejores puntajes en esta sesión de juego. Además debe haber una opción de Volver a Jugar o de ir a MENU. (1 puntos)
    6) En MENU debe haber una UI con los botones de Jugar, Salir y los 2 botones de ON/OFF para el audio de Música y Sonido. (1 Puntos).
    7) Se debe integrar Música de Fondo en las diferentes escenas y los SFX correspondientes. (1 puntos).
    8) Se debe implementar materiales y feedback visual para las diferentes interacciones, personajes, objetos, etc. (2 puntos).
    9) Se debe implementar Scriptable Objects para controladores, datos de objetos, personajes o configuraciones (4 puntos).
    10) Se debe implementar Managers o Controladores que estén asociados entre sí correctamente, e implementen un sisema de eventos. Por lo menos debe haber 3 eventos con un total de 9 subscripciones. (4 puntos).