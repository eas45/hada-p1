﻿hada-p1

P1. ¿Qué crees que significa la opción -n en el comando revert?
	Significa que deshaga el commit al que apunta el puntero que le indicamos después de esta opción.

P2. ¿Qué cambios se han producido al ejecutar el comando reset?
	El repositorio ha vuelto al estado del último commit que se había hecho.

P3. ¿Qué diferencias observas entre revert y reset?
	Con revert podemos volver a un commit anterior especificado con HEAD o HEAD~n. Con reset volvemos al estado inicial del último commit.

P4. ¿Qué diferencias observas entre merge y rebase?
	Rebase unifica las ramas y borra el historial de commits de la rama unificada, a diferencia de merge que mantiene la estructura desde gitk