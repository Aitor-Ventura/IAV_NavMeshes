_Modifica el proyecto "Agentes en el Nav Mesh" para incluir un First Person Controller, de forma que tres tipos distintos de agente persigan al jugador. Crea tipos de agentes con propiedades diferentes para que se generen NavMeshes diferentes para cada tipo (como hicimos en el proyecto "Múltiples NavMesh para distintos tamaños de agente"), de forma que tengan que buscar caminos alternativos para perseguir al jugador._

_Opcional: en lugar de usar cápsulas, descarga modelos 3D de Mixamo (o de otra fuente) y anímalos con los scripts que hemos usado para que se adapte su movimiento al del Nav Mesh Agent._

---
Se desarrolló un controlador de primera persona básico que se le incorporó al objeto jugador. Se desarrollaron diferentes tipos de agentes que se diferencian en su color (Amarillo, Azul, Rojo, Verde). Para los agentes se utilizó un modelo 3D de robot de Maximo y se les asignó una animación que hace que parezca que vuelan. 

La velocidad del agente, la aceleración, la altura, así como la velocidad de la animación del mismo dependen de su tamaño, que es un valor generado aleatoriamente entre 0.25 y 0.85.

![](gif.gif)
