var q = ["En verano hace calor y en invierno _______<br /><br />", "De día sale el ______<br /><br />", "Un año tiene doce ______<br /><br />", "Los colores primarios son azul, rojo y ________<br /><br />", "Las operaciones matemáticas son suma, resta, multiplicación y __________<br /><br />"];
var a1 = ["<button class=buttons002 onclick=q1c()>frío</button>",
    "<button class=buttons002 onclick=q2i()>arcoiris</button>",
    "<button class=buttons002 onclick=q3c()>meses</button>",
    "<button class=buttons002 onclick=q4i()>verde</button>",
    "<button class=buttons002 onclick=q5i()>erosión</button>"];

var a2 = ["<button class=buttons002 onclick=q1i()>viento</button>",
    "<button class=buttons002 onclick=q2c()>sol</button>",
    "<button class=buttons002 onclick=q3i()>días</button>",
    "<button class=buttons002 onclick=q4i()>violeta</button>",
    "<button class=buttons002 onclick=q5i()>ecuación</button>"];

var a3 = ["<button class=buttons002 onclick=q1i()>nieve</button>",
    "<button class=buttons002 onclick=q2i()>cielo</button>",
    "<button class=buttons002 onclick=q3i()>semanas</button>",
    "<button class=buttons002 onclick=q4i()>naranja</button>",
    "<button class=buttons002 onclick=q5c()>división</button>"];

var a4 = ["<button class=buttons002 onclick=q1i()>fresco</button>",
    "<button class=buttons002 onclick=q2i()>calor</button>",
    "<button class=buttons002 onclick=q3i()>horas</button>",
    "<button class=buttons002 onclick=q4c()>amarillo</button>",
    "<button class=buttons002 onclick=q5i()>fracción</button>"];

var c = ["¡¡ Excelente !!", "¡¡ Excelente !!", "¡¡ Excelente !!", "¡¡ Excelente !!", "¡¡ Excelente !!"];
var i = [" ¡¡ Intenta de nuevo !!", " ¡¡ Intenta de nuevo !!", " ¡¡ Intenta de nuevo !!", " ¡¡ Intenta de nuevo !!", " ¡¡ Intenta de nuevo !!"];

var n = 0;
n++;
var s = 0;
s++;

function begin001() {
    disappear001.innerHTML = "";
    message001.innerHTML = "";
    question001.innerHTML = q[0];
    option001.innerHTML = a1[0];
    option002.innerHTML = a2[0];
    option003.innerHTML = a3[0];
    option004.innerHTML = a4[0];
    number001.innerHTML = n++;
}

function q1c() {
    answer001.innerHTML = "<div id=green001>" + c[0] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new002()>Siguiente</button>";
    score001.innerHTML = s++;
}

function q1i() {
    answer001.innerHTML = "<div id=red001>" + i[0] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new002()>Siguiente</button>";
}

function new002() {
    question001.innerHTML = q[1];
    option001.innerHTML = a1[1];
    option002.innerHTML = a2[1];
    option003.innerHTML = a3[1];
    option004.innerHTML = a4[1];
    next001.innerHTML = "";
    answer001.innerHTML = "";
    number001.innerHTML = n++;
}

function q2c() {
    answer001.innerHTML = "<div id=green001>" + c[1] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new003()>Siguiente</button>";
    score001.innerHTML = s++;
}

function q2i() {
    answer001.innerHTML = "<div id=red001>" + i[1] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new003()>Siguiente</button>";
}

function new003() {
    question001.innerHTML = q[2];
    option001.innerHTML = a1[2];
    option002.innerHTML = a2[2];
    option003.innerHTML = a3[2];
    option004.innerHTML = a4[2];
    next001.innerHTML = "";
    answer001.innerHTML = "";
    number001.innerHTML = n++;
}

function q3c() {
    answer001.innerHTML = "<div id=green001>" + c[2] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new004()>Siguiente</button>";
    score001.innerHTML = s++;
}

function q3i() {
    answer001.innerHTML = "<div id=red001>" + i[2] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new004()>Siguiente</button>";
}

function new004() {
    question001.innerHTML = q[3];
    option001.innerHTML = a1[3];
    option002.innerHTML = a2[3];
    option003.innerHTML = a3[3];
    option004.innerHTML = a4[3];
    next001.innerHTML = "";
    answer001.innerHTML = "";
    number001.innerHTML = n++;
}

function q4c() {
    answer001.innerHTML = "<div id=green001>" + c[3] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new005()>Siguiente</button>";
    score001.innerHTML = s++;
}

function q4i() {
    answer001.innerHTML = "<div id=red001>" + i[3] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=new005()>Siguiente</button>";
}

function new005() {
    question001.innerHTML = q[4];
    option001.innerHTML = a1[4];
    option002.innerHTML = a2[4];
    option003.innerHTML = a3[4];
    option004.innerHTML = a4[4];
    next001.innerHTML = "";
    answer001.innerHTML = "";
    number001.innerHTML = n++;
}

function q5c() {
    answer001.innerHTML = "<div id=green001>" + c[4] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=end001()>Finalizar</button>";
    score001.innerHTML = s++;
}

function q5i() {
    answer001.innerHTML = "<div id=red001>" + i[4] + "</div>";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<button class=buttons001 onclick=end001()>Finalizar</button>";
}

////function new006() {
////    question001.innerHTML = q[5];
////    option001.innerHTML = a1[5];
////    option002.innerHTML = a2[5];
////    option003.innerHTML = a3[5];
////    option004.innerHTML = a4[5];
////    next001.innerHTML = "";
////    answer001.innerHTML = "";
////    number001.innerHTML = n++;
////}

////function q6c() {
////    answer001.innerHTML = "<div id=green001>" + c[5] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new007()>Siguiente</button>";
////    score001.innerHTML = s++;
////}

////function q6i() {
////    answer001.innerHTML = "<div id=red001>" + i[5] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new007()>Siguiente</button>";
////}

////function new007() {
////    question001.innerHTML = q[6];
////    option001.innerHTML = a1[6];
////    option002.innerHTML = a2[6];
////    option003.innerHTML = a3[6];
////    option004.innerHTML = a4[6];
////    next001.innerHTML = "";
////    answer001.innerHTML = "";
////    number001.innerHTML = n++;
////}

////function q7c() {
////    answer001.innerHTML = "<div id=green001>" + c[6] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new008()>Siguiente</button>";
////    score001.innerHTML = s++;
////}

////function q7i() {
////    answer001.innerHTML = "<div id=red001>" + i[6] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new008()>Siguiente</button>";
////}

////function new008() {
////    question001.innerHTML = q[7];
////    option001.innerHTML = a1[7];
////    option002.innerHTML = a2[7];
////    option003.innerHTML = a3[7];
////    option004.innerHTML = a4[7];
////    next001.innerHTML = "";
////    answer001.innerHTML = "";
////    number001.innerHTML = n++;
////}

////function q8c() {
////    answer001.innerHTML = "<div id=green001>" + c[7] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new009()>Siguiente</button>";
////    score001.innerHTML = s++;
////}

////function q8i() {
////    answer001.innerHTML = "<div id=red001>" + i[7] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new009()>Siguiente</button>";
////}

////function new009() {
////    question001.innerHTML = q[8];
////    option001.innerHTML = a1[8];
////    option002.innerHTML = a2[8];
////    option003.innerHTML = a3[8];
////    option004.innerHTML = a4[8];
////    next001.innerHTML = "";
////    answer001.innerHTML = "";
////    number001.innerHTML = n++;
////}

////function q9c() {
////    answer001.innerHTML = "<div id=green001>" + c[8] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new010()>Siguiente</button>";
////    score001.innerHTML = s++;
////}

////function q9i() {
////    answer001.innerHTML = "<div id=red001>" + i[8] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=new010()>Siguiente</button>";
////}

////function new010() {
////    question001.innerHTML = q[9];
////    option001.innerHTML = a1[9];
////    option002.innerHTML = a2[9];
////    option003.innerHTML = a3[9];
////    option004.innerHTML = a4[9];
////    next001.innerHTML = "";
////    answer001.innerHTML = "";
////    number001.innerHTML = n++;
////}

////function q10c() {
////    answer001.innerHTML = "<div id=green001>" + c[9] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=end001()>Finalizar</button>";
////    score001.innerHTML = s++;
////}

////function q10i() {
////    answer001.innerHTML = "<div id=red001>" + i[9] + "</div>";
////    option001.innerHTML = "";
////    option002.innerHTML = "";
////    option003.innerHTML = "";
////    option004.innerHTML = "";
////    next001.innerHTML = "<button class=buttons001 onclick=end001()>Finalizar</button>";
////}

function end001() {
    message001.innerHTML = "¡¡ Bien jugado !!";
    question001.innerHTML = "";
    option001.innerHTML = "";
    option002.innerHTML = "";
    option003.innerHTML = "";
    option004.innerHTML = "";
    next001.innerHTML = "<div id=text001>" + "<button class=buttons001 onclick=repeat001()>Reintentar</button>" + "</div>";
    answer001.innerHTML = "";
}

function repeat001() {
    location.reload();
}