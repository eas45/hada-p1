# hada-p1

P1. �Qu� rama se ha subido exactamente?
	Se ha subido la rama master, aunque tambi�n est�n todas las ramas creadas anteriormente en el proyecto.

P2. �Qu� pasa al utilizar la opci�n Comparar con la versi�n no modificada?
	Aparece la copia del archivo donde se muestra las diferencias del actual y el que est� en el commit.
	Equivale al comando 'git giff'.

P3. �Y ahora ves alg�n cambio en el repositorio remoto? �Por qu�?
	No hay ning�n cambio en el repositorio remoto porque ha habido un conflicto con el fichero README.md que
	Github nos daba la opci�n de crear en la carpeta ra�z del proyecto.

P4. �Qu� significa Confirmar > "Confirmar por etapas" y cu�l ser�a el comando git equivalente?
	Es la forma de hacer commit manualmente.
	Equivale al comando 'git commit -m "msg"'.

P5. �Qu� significa Confirmar > "Confirmar por etapas e insertar" y cu�l ser�a el comando git equivalente?
	Consiste en hacer commit y push.
	Equivale a los comandos 'git commit -m "msg"' y 'git push -u origin'.

P6. �Qu� significa Confirmar > "Confirmar por etapas y sincronizar" y cu�l ser�a el comando git equivalente?
	Hace commit de los cambios del archivo del repositorio locar y al sincronizar, lo que haya en Sincronizaci�n >
	"Confirmaciones de entrada" se extrae y lo que hay en "Confirmaciones de salida" se inserta.
	Equivale a los comandos 'git commit -m "msg"', 'git pull origin' y 'git push -u origin'.

P7. �Qu� es la diferencia entre pulsar Sincronizar o Extraer? �Cu�les ser�an los comandos git equivalentes?
	Al pulsar "Extraer" los cambios del repositorio remoto se ven reflejados en el repositorio local, mientras que
	si se sincroniza, los cambios confirmados del repositorio local se ver�an reflejados en el repositorio remoto
	tambi�n.
	Sincronizar equivale a los comandos 'git pull origin' y 'git push -u origin'.
	Extraer equivale �nicamente al comando 'git pull origin'.

P8. �Qu� significa Ramas > "Fusionar mediante combinaci�n" y cu�l ser�a el comando git equivalente?
	Es la opci�n para fusionar una rama a otra manteni�ndose reflejada la estructura de las ramas y los commits
	realizados en cada una de ellas, adem�s habr�a que confirmar los cambios en la rama en la que se ha fusionado.
	Equivale al comando 'git merge [nombre_rama]'.

P9. �Qu� significa Confirmar > "Fusionar mediante cambio de base" y cu�l ser�a el comando git equivalente?
	Esta opci�n fusiona dos ramas de forma que la que se fusiona con la principal pierde el historial de commits
	y contin�a la linealidad de la rama principal. Despu�s de esto no es necesario confirmar cambios.
	Equivale al comando 'git rebase [nombre_rama]'.