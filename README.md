# hada-p1

P1. ¿Qué rama se ha subido exactamente?
	Se ha subido la rama master, aunque también están todas las ramas creadas anteriormente en el proyecto.

P2. ¿Qué pasa al utilizar la opción Comparar con la versión no modificada?
	Aparece la copia del archivo donde se muestra las diferencias del actual y el que está en el commit.
	Equivale al comando 'git giff'.

P3. ¿Y ahora ves algún cambio en el repositorio remoto? ¿Por qué?
	No hay ningún cambio en el repositorio remoto porque ha habido un conflicto con el fichero README.md que
	Github nos daba la opción de crear en la carpeta raíz del proyecto.

P4. ¿Qué significa Confirmar > "Confirmar por etapas" y cuál sería el comando git equivalente?
	Es la forma de hacer commit manualmente.
	Equivale al comando 'git commit -m "msg"'.

P5. ¿Qué significa Confirmar > "Confirmar por etapas e insertar" y cuál sería el comando git equivalente?
	Consiste en hacer commit y push.
	Equivale a los comandos 'git commit -m "msg"' y 'git push -u origin'.

P6. ¿Qué significa Confirmar > "Confirmar por etapas y sincronizar" y cuál sería el comando git equivalente?
	Hace commit de los cambios del archivo del repositorio locar y al sincronizar, lo que haya en Sincronización >
	"Confirmaciones de entrada" se extrae y lo que hay en "Confirmaciones de salida" se inserta.
	Equivale a los comandos 'git commit -m "msg"', 'git pull origin' y 'git push -u origin'.

P7. ¿Qué es la diferencia entre pulsar Sincronizar o Extraer? ¿Cuáles serían los comandos git equivalentes?
	Al pulsar "Extraer" los cambios del repositorio remoto se ven reflejados en el repositorio local, mientras que
	si se sincroniza, los cambios confirmados del repositorio local se verían reflejados en el repositorio remoto
	también.
	Sincronizar equivale a los comandos 'git pull origin' y 'git push -u origin'.
	Extraer equivale únicamente al comando 'git pull origin'.

P8. ¿Qué significa Ramas > "Fusionar mediante combinación" y cuál sería el comando git equivalente?
	Es la opción para fusionar una rama a otra manteniéndose reflejada la estructura de las ramas y los commits
	realizados en cada una de ellas, además habría que confirmar los cambios en la rama en la que se ha fusionado.
	Equivale al comando 'git merge [nombre_rama]'.

P9. ¿Qué significa Confirmar > "Fusionar mediante cambio de base" y cuál sería el comando git equivalente?
	Esta opción fusiona dos ramas de forma que la que se fusiona con la principal pierde el historial de commits
	y continúa la linealidad de la rama principal. Después de esto no es necesario confirmar cambios.
	Equivale al comando 'git rebase [nombre_rama]'.