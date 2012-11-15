# HTML5 Boilerplate

HTML5 Boilerplate nos ofrece simplificar el proceso de construcci�n de sitios web en HTML5 y para ello nos permite descargar una especie de template o plantilla que puede ayudar no solo a los desarrolladores web novatos, sino tambi�n a los m�s experimentados.

Con H5BP podemos obtener c�digo del mejor (est� desarrollado por gurues como Paul Irish) para: normalizaci�n para todos los navegadores (cross-browsing), optimizaci�n de performance, optmizaciones para navegadores en dispositivos m�viles, clases espec�ficas para IE, clases �no-js� y �js� para estilos basados en capacidades del navegador, un archivo .htaccess que permite el uso correcto de caracter�sticas HTML5 y carga de p�gina m�s r�pida, y mucho m�s; todo hecho teniendo en cuenta las mejores pr�cticas de hoy en d�a en el desarrollo web.

Incluso aunque no lo vayas a usar, puede ser algo muy instructivo el solo hecho de ver c�mo est� desarrollado.

Al visitar el [sitio](http://html5boilerplate.com/) tienes 3 opciones: descargar la versi�n comentada y explicada, descargar la versi�n sin comentarios o la opci�n de personalizar lo que descargues.

**Para "News At A Glance" tome en cuenta las siguientes consideraciones:** (Para mayor detalle referirse a [HTML5 Boilerplate documentation](https://github.com/h5bp/html5-boilerplate/blob/master/doc/TOC.md))

* El orden de los meta tags y &lt;title>:

	> Como se recomienda en las especificaciones de HTML5, se debe agregar la 
	declaraci�n de "charset" tempranamente (antes de cualquier ASCII) para evitar un potencial problema de seguridad relacionado al encoding en IE.

	> El charset deber�a, adem�s, aparecer antes del &lt;title> para evitar 
		un potencial [XSS vectors]( http://code.google.com/p/doctype-mirror/wiki/ArticleUtf7 ).

	> El meta tag que define la comptibilidad necesita estar antes que todos 
		los elementos (&lt;!DOCTYPE html>).

* X-UA-Compatible

	> Esto asegura que la �ltima version de IE es usada en versiones de IE que contienen multiples motores de renderizado. Aun, si se estuviese usando IE8 o IE9, es posible que ellos no esten usando el �ltimo motor de renderizado que el browser contiene.
		Entonces, para solucionar esto, se usa: <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">

	> El meta tag le dice al motor de renderizado de IE 2 cosas:
		 1) Deber�a usar la �ltima version (edge) del motor de renderizado.
		 2) Si est� instalado deber�a usar el motor de renderizado Google Chrome Frame.

	> Este meta tag asegura que cualquiera que "browsee" tu sitio ser� "recibido" con la mejor expriencia de usuario posible que su browser pueda ofrecer.

* Modernizr

	> HTML5 Boilerplate usa un build customizado de Modernizr.

	> Modernizr es una librer�a de Javascript la cual nos ofrece la posibilidad de detectar el soporte que tiene el actual navegador para la especificaci�n de HTML5 y adem�s nos permite crear un estilo css en caso de que la especificaci�n de css3 no funcione. Y para IE permite dar estilo a las nuevas etiquetas de HTML5.

	> En general, con el fin de minimizar el tiempo de carga de la pagina, es mejor llamar a cualquier js al final de la pagina. Pero, dicho esto, el script de Modernizr necesita correr antes que el browser comienze a renderizar la p�gina, por lo que los browsers que carecen de apoyo para algunos de los nuevos elementos de HTML5 sean capaces de manejarlos adecuadamente. Por lo tanto, el script Modernizr es el �nico js sincrono cargado al comienzo del documento.
		
* Google CDN for jQuery

	> La version de Google CDN de la librer�a de JQuery es referenciada hacia el final de la pagina usando un [protocolo independiente](https://github.com/h5bp/html5-boilerplate/blob/master/doc/faq.md).

	> Una refencia a una librer�a local de JQuery es incluida para los raros casos en que la version de CDN no se encuentre disponible, y para facilitar el desarrollo off-line.
		
		