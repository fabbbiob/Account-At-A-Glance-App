# jQuery Plugin [jquery-tmpl](http://api.jquery.com/category/plugins/templates/)

    (*)Aclaraci�n

    Es conveniente aclarar que el equipo de jQuery ha decidido no 
    hacer uso de este plugin ya que no est� siendo activamente desarrollado 
    o mantenido desde hace un tiempo ya.
    Cuando se comenz� a utilizar en el self training no se ten�a conocimiento
    de esto pero de todos modos, para el uso que se le di�, fue �til y 
    funcion� correctamente.

##Uso en News At A Glance
###Situaci�n planteada

Se necesitaba poder contar con templates para los diferentes tama�os de
'tiles' que deb�a mostrar, y manejar, la aplicaci�n (small, medium y large)
para los diferentes tipos de informaci�n mostrada (noticias, equipos y
videos publicitarios)
    
###Resoluci�n usando _jquery-tmpl_ plugin

1. [Descargar](http://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.min.js) e incluir en el proyecto el plugin: _&lt;script src="@Url.Content("~/Scripts/Libs/jQuery.tmpl.min.js")" type="text/javascript">&lt;/script>_

2. Agregar un archivo html para cada tipo de informaci�n a mostrar (noticias, equipos, videos). En nuestro caso, para las noticias, se agreg� News.html.

3. Dentro de cada archivo incluir los 3 templates, 1 para cada tama�o de tile considerado: small, medium y large. El tag principal del template debe tener la siguiente forma: _&lt;script id="NewsTemplate\_Small" type="text/x-jquery-tmpl">_ (template para noticia tama�o small).

4. Ahora, usando _$( "#myTemplate" ).tmpl( [data] )_ se indica que el **template** correspondiente se bindear� con determinada **data** (puede ser alg�n JavaScript type, incluyendo Array u Object).

    En la app: 

    var template = $('#' + tileName + 'Template_' + size); **(se obtiene el template)**

    template.tmpl(data); **(se bindea la data correspondiente)**

5. Para identificar los valores a tener en cuenta al momento de renderizar la **data** sobre el **template** se debe considerar la siguiente sintaxis en la definici�n del template: _&lt;span id="spNewsSource">${Source}_&lt;/span>. 
Con el template tag: "${Source}" se indica que la **data** pasada por parametro tendr� una property llamada "Source" con un value que ser� renderizado sobre el _&lt;span>_ en cuesti�n.
**Se puede bindear de esta forma ya sea el _value_ de un span como la property _ref_ en un anchor _&lt;a id="lnkNews" href="${Url}"_, el _source_ de una imagen, los ids de elementos html, etc.**
Ver documentaci�n para los varios template tags: [${}](http://api.jquery.com/template-tag-equal), [{{each}}](http://api.jquery.com/template-tag-each), [{{if}}](http://api.jquery.com/template-tag-if), [{{else}}](http://api.jquery.com/template-tag-else), [{{html}}](http://api.jquery.com/template-tag-html), [{{tmpl}}](http://api.jquery.com/template-tag-tmpl) [{{wrap}}](http://api.jquery.com/template-tag-wrap).

6. El m�todo _$.tmpl()_ retorna una  _jQuery collection_ y es dise�ado para encadenar con .appendTo, .prependTo, .insertAfter or .insertBefore, como en este ejemplo: _$.tmpl( "&lt;li>${Name}&lt;/li>", { "Name" : "John Doe" }).appendTo( "#target" )_.
**En la app**, el valor retornado por este m�todo , se utiliz� de la siguiente manera: _tileDiv.html(template)_ (Para el div del tile en cuesti�n se define la property **html** usando el **template**).

###Conclusi�n
El plugin permiti� una gran comodidad y facilidad para mostrar, bindear y manejar templates previamente definidos sobre los cuales deb�a mostrarse diferente informaci�n, dependiendo del tama�o del template, de manera din�mica (en el momento de la obtenci�n de la noticias).