# 🌱 TALLER 1 (repaso):
## 🌻 Miembros que participaron:
- Solo yo (000540365)
:(

## Explicación
Hice un método de inicio para recordar cómo hacer menús funcionales, porque llevaba tiempo sin tocar nada de eso. De ahí, se elige cuál ejercicio quieres ejecutar. También hice un método para imprimir textos con colorcitos porque lo iba a hacer mucho :]

### ☀️ **Ejercicio 1:**
1. Pide el valor de n y lo parsea a int.
2. Valida que el número sea positivo o > 0, porque no tiene sentido que no lo sea...
3. Llama al método para hacer print a los números primos de la secuencia.
> 1. Toma a y b como 0 y 1 (los valores iniciales de la secuencia)
> 2. Sabemos que empiezan a ser primos desde el 2, entonces comienzo el loop con i = 2.
> 3. Hace la suma de los valores de a y b.
> 4. Llama la función `EsPrimo` que devuelve un loop. Si es true, lo escribe... y si no, ignora.
> > 1. EsPrimo recibe el número y revisa 3 condiciones especiales: si es menor que 2, sabemos que no es primo... si es 2, es primo... y si es divisible entre 2 sin residuo, no es primo (aquí no cuenta al 2, porque ya lo habría returneado en la línea anterior).
> > 2. Si no cumple con ninguna de esas condiciones, entonces ahí sí revisa que sea primo usando el método de la raíz cuadrada.
> 6. Actualiza los valores de a y b, y sigue ejecutando el loop hasta llegar a i < n.

### ☀️ **Ejercicio 2:**
1. Pide el valor de segundos y los parsea a int.
2. Valida que sí sea una cantidad lógica (por lo menos 0)
3. Saco las horas dividiendo los segundos entre 3600 (cantidad de segundos en una hora). Al ser int, ignora cualquier parte decimal.
4. Saco los minutos dividiendo lo que me queda al sacar las horas (es decir, la parte que no sea entera) entre 60 (cantidad de segundos en un minuto).
5. Saco los segundos dividiendo lo que me queda al sacar los minutos (parte no entera de la división entre 60)
6. Muestro el resultado usando {variable:D2} para que tenga 2 dígitos.

### ☀️ **Ejercicio 3:**
1. Guardo el valor apostado
2. Pido el número ganador y el número apostado, parseando ambos en int.
3. Valida que los números sean de 4 cifras.
4. Llama la función para determinar el premio y almacena el resultado en la variable.
> 1. `DeterminarPremio` recibe el número ganador, el adivinado, y la cantidad de dinero apostada. Revisa cada una de las condiciones, y multiplica por la cantidad asociada.
> 2. Para saber si cumple con las 4 en el mismo orden, solamente hay que comparar con == que sean igual.
> 3. para revisar si son las mismas cifras en desorden, llama al método correspondiente que retorna un bool.
> > El método guarda los dos números como strings y recorre char por char para ver si algo coincide, borrando el número del string de la respuesta para evitar repeticiones. Va subiendo un counter con cada coincidencia, y si son exactamente 4, significa que las 4 cifras coinciden y devuelve un true.
> Y para revisar si las últimas n cifras son iguales, como sé que los números siempre son de 4 cifras, divido ambos números por 1000, 100 y 10 y comparo sus partes decimales. :]
5. Pongo un mensaje diciendo si ganaste o no, y cuánta plata es.

### ☀️ **Ejercicio 4:**
1. Instancio el MessageManager (tengo entendido que no hay problema porque es local, entonces se destruye cuando termina el método)
2. Pido el mensaje a mandar.
3. Llama el método print del MessageManager instanciado.
> 1. En el de PrintNormal, el método InvertMessage es el mismo (convierte mensaje a array de chars, lo invierte y lo retorna).
> 2. Luego toma el mensaje, lo convierte a array otra vez y lo empieza a recorrer. Invierte mayúsculas y minúsculas, y los espacios o signos de puntuación los deja quietos. Escribe el resultado.
> 3. En el PrintCapsInvertidas, el método de Print no hace nada distinto (sólo printea el invertido) y el método de InvertMessage cambia todas las mayúsculas por minúsculas.
4. El MessageManager instancia las dos clases en su constructor, y tiene un método print propio donde llama el print de ambos al tiempo.

## 🌻Cosas que aprendí
- Que podía usar índices en strings también, porque en realidad C# los interpreta como un array de chars :O
- Que la función `.Remove` en esos strings no cambia el string que le doy, sino que me devuelve uno nuevo sin ese/esos elemento/s.
- Que usando el `%` podía sacar los últimos dígitos en vez de tener que hacer cosas con arrays, listas y eso.
- Qué es la secuencia de Fibonacci
- Que usando `{variable:D2}` podía hacer que me mostrara los números con 2 dígitos.

___
