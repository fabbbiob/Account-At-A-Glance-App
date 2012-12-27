#[Flot](http://www.flotcharts.org/) (librer�a javascript para JQuery)
(*) En GitHub: https://github.com/flot/flot/blob/master/README.md

###Instalaci�n 
[Descargar](http://www.flotcharts.org/) e incluir el archivo javascript despu�s de la inclusi�n del archivo de JQuery.
_(Generalmente todos los browsers que soportan el tag de HTML5 canvas soportan el uso del plugin)_

###Uso b�sico
1. Crear un div contenedor para poner el gr�fico _&lt;div id="placeholder">&lt;/div>_.

2. Se necesita definir el ancho y el alto del div porque sino la librer�a de ploteado no sabe manejar la escala del gr�fico: _&lt;div id="placeholder" style="width:600px;height:300px">&lt;/div>_

3. Cuando el div est� listo en el DOM invocamos a la funci�n **plot**: _$.plot($("#placeholder"), data, options);_

4. La **data** es un arreglo con las series a bindear y **options** es un objeto con diversos settings para customizar la gr�fica resultante del ploteado.
Este es un ejemplo r�pido que dibuja una l�nea desde el punto (0,0) a (1,1): _$.plot($("#placeholder"), [ [[0, 0], [1, 1]] ], { yaxis: { max: 1 } });_

(*)La funci�n **plot** inmediatamente dibuja la gr�fica y returna un objeto _plot_ con algunos m�todos.

##Uso en News At A Glance
###Situaci�n planteada
Graficar el progreso en la posici�n en el campeonato para un determinado equipo.

###Soluci�n usando el plugin
1. En el archivo de Team.html, donde se encuentran los [templates](https://github.com/leoslopez/Account-At-A-Glance-App/blob/master/AccountAtAGlance/NewsAtAGlance/docs/Jquery%20Templates.md) definidos para los distintos tama�os de informaci�n a mostrar para un equipo, se defini� el div contenedor del gr�fico de la siguiente manera: _&lt;div id="progressPositionCanvas${GraphName}" class="canvas">&lt;/div> (esto para el template de tama�o large)

2. En la funcion _formatTeams_ del _scene.tile.formatter.js_ se obtiene el div contenedor: _var canvasDiv = $('#progressPositionCanvas' + 
tileDiv.data().tileData.GraphName);_

3. Luego se invoca a la funci�n _renderCanvas_ pasandole este div previamente obtenido (m�s otros valores como la data a bindear, ancho, alto, etc): _renderCanvas(canvasDiv, width, height, json.AltColor, json, json.PositionProgress);_

4. Dentro de _renderCanvas_ lo que hacemos es armar el arreglo de puntos a bindear (_points_), definimos un objeto chartOptions que son los settings para customizar la gr�fica: 

                _var chartOptions = {
                series: {
                    lines: { show: true, fill: true },
                    points: { show: true, radius: 10 }
                },

                grid: { hoverable: true, autoHighlight: true },
                legend: { position: 'se' },

                // Explaination for tickFormatter definition: Max value on axis Y is replaced by custom string: 'Pos.'. The same to the axis X.
                yaxis: { max: maxY, min: 1, tickFormatter: function (val, axis) { return val < axis.max ? val.toFixed(0) : "Pos."; } },
                xaxis: { max: maxX, min: 1, tickFormatter: function (val, axis) { return val < axis.max ? val.toFixed(0) : "Fecha"; } }
            };_
Se puede notar como se define el m�ximo y m�nimo para el eje X e Y. Se defina la ubicaci�n de la leyenda sobre la gr�fica. Se indica que se haga highlight autom�tico cuando se pasa el mouse sobre la gr�fica. Se define, tambi�n, para las series el tama�o de los puntos y el formato de las l�neas. Y se pueden definir varias opciones m�s.

5. Por ultimo invocamos a **plot** para dibujar la gr�fica con los datos y las opciones que definimos: $.plot(canvasDiv, chartOptions);

###Conclusi�n
Muy sencilla manera de aprovechar la caracter�stica canvas de HTML5 para construir gr�ficas agradables y con muchas opciones m�s de las aqu� explicadas.
