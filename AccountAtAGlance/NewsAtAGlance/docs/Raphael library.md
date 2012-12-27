#[Raphael](http://raphaeljs.com/) javascript library

Raphael es una librer�a javascript que deber�a simplificar el trabajo con Scalable Vector Graphics (SVG) en la web.
Si se quiere crear un determinado gr�fico y rotarlo, por ejemplo, debiera ser alcanzado de manera simple con el uso de esta librer�a.

(*)Es recomendable una introducci�n en el tema de [Scalable Vector Graphics SVG](http://www.w3schools.com/html/html5_svg.asp).

##Uso en News At A Glance
###Situaci�n planteada
Realizar una gr�fica de torta con los porcentajes de las cantidades de goles hecho de las diferentes lineas de un equipo de f�tbol (arquero, defensores, mediocampistas y delanteros).

###Soluci�n usando el plugin
1. Descargar e incluir en el proyecto la librer�a [Raphael](https://raw.github.com/DmitryBaranovskiy/raphael/master/raphael-min.js).

2. Descargar e incluir en el proyecto el [plugin](https://raw.github.com/DmitryBaranovskiy/g.raphael/master/min/g.pie-min.js) para hacer gr�fica de tortas basado en la librer�a Raphael.

3. Ya en el c�digo relacionado a la app, definir en el archivo de [templates](https://github.com/leoslopez/Account-At-A-Glance-App/blob/master/AccountAtAGlance/NewsAtAGlance/docs/Jquery%20Templates.md) de equipos ( _Team.html_ ), en el template de tama�o medium, el siguiente div contendor de la gr�fica: _&lt;div id="goalsPieSVG${GraphName}" class="goalsPieDiv" />_.

4. Luego, en la funci�n _formatTeams_ del archivo _scene.tile.formatter.js_ se obtiene ese div: _var namePieDiv = 'goalsPieSVG' + tileDiv.data().tileData.GraphName;_

5. Por �ltimo, en esa misma funci�n, _formatTeams_, se hace lo siguiente:

                    values.push(tileDiv.data().tileData.Goals_GK);
                    labels.push(tileDiv.data().tileData.Goals_GK + ' goles \r\n Arq.');

                    values.push(tileDiv.data().tileData.Goals_Def);
                    labels.push(tileDiv.data().tileData.Goals_Def + ' goles \r\n Def.');

                    values.push(tileDiv.data().tileData.Goals_Mid);
                    labels.push(tileDiv.data().tileData.Goals_Mid + ' goles \r\n Med.');

                    values.push(tileDiv.data().tileData.Goals_Forw);
                    labels.push(tileDiv.data().tileData.Goals_Forw + ' goles \r\n Del.');                    

Este c�digo, previo a hacer la llamada a _pieChart_, define los valores a graficar (goles para las diferentes l�neas del equipo) y los labels relacionados a estos valores (con el fin de que, al posicionarse con el mouse sobre cada secci�n de la torta, se de la descripci�n correspondiente).

/6. Por �ltimo, se invoca al metodo _pieChart_ con el ancho, alto, el array de values, el array de labels relacionados a estos values y el color definido para los labels: _raphael(namePieDiv, 300, 400).pieChart(130, tileDiv.data().scenes[sceneId].top + 80, 50, values, labels, "#fff");_.

###Conclusi�n
Sencilla y potente manera de graficar y manipular gr�ficas en la web. El uso dado dentro de _"News At A Glance"_ es m�nimo; hay much�simas cosas agradables e interesantes para llevar a cabo haciendo uso de la librer�a [Raphael](http://raphaeljs.com/), aprovechando la feature de SVG de HTML5. Adem�s de muchos plugins que se basan en la misma.