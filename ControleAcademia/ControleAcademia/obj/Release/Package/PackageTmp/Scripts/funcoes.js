var horas = [6, 7, 9, 10, 12, 13, 15, 16, 18, 19, 21];
var minutos = [0, 30];


function somenteNumeros(evt)
{
  var charCode = (evt.which) ? evt.which : event.keyCode
  if (charCode > 31 && (charCode < 48 || charCode > 57))
    return false;
  return true;
}



function horarioFinal(time) {


    if (validaHora(time)) {

        var hora = time.substring(0, 2);
        var min = time.substring(5, 2).replace(':', '');

        var data = new Date();
        var data1 = new Date(data.getFullYear(), data.getMonth(), data.getDay(), hora, min);
        
        data1.setMinutes(data1.getMinutes() + 90);
        var horarioFinal = data1.getHours().toString() + ":" + data1.getMinutes().toString();
        alert(horarioFinal);
    }
    else {
        alert('Horario inicial invalido.');
    }

}


function validaMinuto(time) {

    
    var min = time.substring(5, 2).replace(':', '');
    var minInt = parseInt(hora);
    var result = minutos.includes(minInt);
    return result;

}



function validaHora(time) {

    
    var hora = time.substring(0, 2);
    var horaInt = parseInt(hora);
    var result = horas.includes(horaInt);
    return result;

}