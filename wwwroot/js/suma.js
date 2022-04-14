
var num1, num2;
var respuesta;
var indiceOpCorrecta;

txt_suma = document.getElementById("suma");
op1 = document.getElementById("op1");
op2 = document.getElementById("op2");
op3 = document.getElementById("op3");
txt_msj = document.getElementById("msj");
txt_resultado = document.getElementById("resultado");

function comenzar() {
    txt_resultado.innerHTML = "?";
    txt_msj.innerHTML = "";

    num1 = Math.round(Math.random()*9);
    num2 = Math.round(Math.random()*9);
    respuesta = num1 + num2;

    txt_suma.innerHTML = num1 + "+" + num2 + "=";

    indiceOpCorrecta = Math.round(Math.random()*2);

    if (indiceOpCorrecta == 0) {
        op1.innerHTML = respuesta;
        op2.innerHTML = respuesta + 1;
        op3.innerHTML = respuesta - 1;
    }
    if (indiceOpCorrecta == 1) {
        op2.innerHTML = respuesta;
        op1.innerHTML = respuesta + 2;
        op3.innerHTML = respuesta - 1;
    }
    if (indiceOpCorrecta == 2) {
        op3.innerHTML = respuesta;
        op1.innerHTML = respuesta + 1;
        op2.innerHTML = respuesta - 1;
    }
}

function controlarRta(opcionElegida) {
    txt_resultado.innerHTML = opcionElegida.innerHTML;

    if (respuesta == opcionElegida.innerHTML) {
        txt_msj.innerHTML = "¡¡ Excelente !!";
        txt_msj.style.color = "green";
        setTimeout(comenzar, 2000);
    } else {
        txt_msj.innerHTML = " ¡¡ Intenta de nuevo !!";
        txt_msj.style.color = "red";
        setTimeout(limpiar, 2000);
    }

}

function limpiar() {
    txt_resultado.innerHTML = "?";
    txt_msj.innerHTML = "";
}

comenzar();