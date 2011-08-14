//jQuery.noConflict();

$(document).ready(function (){
//efekt po najechaniu najechaniu na zakladkę
$(".zakladka").mouseover(function() {
$(this).animate({
	width: "245", //szerokość zakładki
	}, 140 //czas animacji w milisekundach
		  );
});


//powrót do pierwotnej formy zakładki
$(".zakladka").mouseout(function() {
$(this).animate({
	width: "230" //rozszerzenie zakładki
	}, 150 //czas animacji w milisekundach
		  );
});
//efekt pozycji podmenu
$("li").mouseover(function() {
	$(this).animate({
		opacity: 0.5, //przezroczystość elementu na 50%
		paddingLeft: "0.3em" // małe przesunięcie treści  
		}, 155 //czas animacji w milisekundach
		      );
});
//powrót do pierwotnej formy podmenu
	$("li").mouseout(function() {
		$(this).animate({
			opacity: 1.0, //przezroczystość elementu na 100%
    		paddingLeft: "0.0em"
			});
});
	$("ul#mSlider").hide(); // ukrywa podmenu
 	$('.zakladka').click(function(){
		//akcja po kliknięciu w zakładkę
		$(this).next('ul#mSlider').slideToggle(300); 
	}); 
});

