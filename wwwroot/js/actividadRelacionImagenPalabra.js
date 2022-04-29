// * * * MODAL * * * //

if (window.location == '*/Index.html') {
    var confirmExitModal = document.getElementById('confirmExitModal');
    confirmExitModal.addEventListener('show.bs.modal', function (event) {
        // Button that triggered the modal
        var button = event.relatedTarget;
        // Extract info from data-bs-* attributes
        // var id = button.getAttribute('asp-route-id');

        // var modalExitBtn = document.getElementById('salir');
        //modalDeleteBtn.setAttribute('asp-controller', 'Paciente');
        //modalDeleteBtn.setAttribute('asp-action', 'Details');
        //modalDeleteBtn.setAttribute('asp-route-id', id);
    });
}

/* * * * * * * * * * */


// * * * ACTIVITY * * * //

const gameStuff =
[
    {
        src: '/img/naturaleza/lago.png',
        optA: "Lago",
        optB: "Río",
        optC: "Mar",
        ok: "1"
    },
    {
        src: '/img/naturaleza/montaña.png',
        optA: "Playa",
        optB: "Cerro",
        optC: "Montaña",
        ok: "3"
    },
    {
        src: '/img/naturaleza/nieve.png',
        optA: "Granizo",
        optB: "Lluvia",
        optC: "Nieve",
        ok: "3"
    },
    {
        src: '/img/naturaleza/sol.png',
        optA: "Nube",
        optB: "Sol",
        optC: "Arcoiris",
        ok: "2"
    },
    {
        src: '/img/naturaleza/arco.png',
        optA: "Arcoiris",
        optB: "Estrella",
        optC: "Sol",
        ok: "1"
    }
];

// Global Variables
var currentImg = 0;
var score = 0;
var totalImgs = gameStuff.length;
var img;
var flag = -1;

// Containers
const gameContainerElement = document.getElementById("gameContainer");
const menuContainer = document.getElementById('menuContainer');
const imgContainerElement = document.getElementById("imgContainer");
const optsContainerElement = document.getElementById("optionsContainer");
const formContainerElement = document.getElementById("formContainer");

// Options Buttons
const btnOptionAElement = document.getElementById("optA");
const btnOptionBElement = document.getElementById("optB");
const btnOptionCElement = document.getElementById("optC");

// Next Q Button
const nextBtn = document.getElementById('nextBtn');

// Menu Buttons
const startBtn = document.getElementById('startBtn');
const exitBtn = document.getElementById('exitBtn');

function showMenu()
{
    imgContainerElement.style.display = "none";
    optsContainerElement.style.display = "none";
    formContainerElement.style.display = "none";
    btnOptionAElement.style.display = "none";
    btnOptionBElement.style.display = "none";
    btnOptionCElement.style.display = "none";
    nextBtn.style.display = "none";

    menuContainer.style.display = "block";
}

function hideMenu()
{
    imgContainerElement.style.display = "block";
    optsContainerElement.style.display = "block";
    formContainerElement.style.display = "block";
    btnOptionAElement.style.display = "block";
    btnOptionBElement.style.display = "block";
    btnOptionCElement.style.display = "block";
    nextBtn.style.display = "block";

    menuContainer.style.display = "none";
}

function exitGame()
{
    startBtn.innerText = "Realizar Nuevamente";
    startBtn.setAttribute('class', 'btn btn-success rounded-pill p-1 col-5');
    exitBtn.setAttribute('class', 'btn btn-outline-secondary rounded-pill p-1 col-5');
    falg = -1;
    currentImg = 0;
    score = 0;
    showMenu();
}

function showImg(qIndex)
{
    hideMenu();
    flag++;

    var q = gameStuff[qIndex];
    img = document.createElement('img');
    /*img.setAttribute('class', 'img-fluid');*/
    img.setAttribute('src', gameStuff[qIndex].src);
    img.setAttribute('width', '220px');
    img.setAttribute('height', '220px');
    imgContainerElement.appendChild(img);

    btnsTxt(q);
}

function btnsTxt(q)
{
    if (currentImg === totalImgs - 1)
    {
        nextBtn.setAttribute('class', 'btn btn-outline-primary rounded-pill p-1 col-6 col-md-4');
        nextBtn.textContent = "Terminar";
    }
    else
    {
        nextBtn.textContent = "Siguiente";
    }

    nextBtn.setAttribute('type', 'button');
    nextBtn.setAttribute('onclick', 'showNextImg()');
    nextBtn.setAttribute('class', 'btn btn-outline-secondary rounded-pill p-1 col-6 col-md-4');
    btnOptionAElement.innerHTML = q.optA;
    btnOptionBElement.innerHTML = q.optB;
    btnOptionCElement.innerHTML = q.optC;
};

function showNextImg()
{
    var selectedOption = document.querySelector('input[type=radio]:checked');

    if (!selectedOption)
    {
        alert("Por favor, selecciona una respuesta.");
        return;
    }

    var answer = selectedOption.value;

    if (gameStuff[currentImg].ok === answer)
    {
        score += 10;
        console.log(score);
    }

    selectedOption.checked = false;
    imgContainerElement.removeChild(img);
    currentImg++;
    
    if (currentImg === totalImgs)
    {
        exitGame();
    }
    if (currentImg > 0 && currentImg < gameStuff.length) {
        showImg(currentImg)
    }
};

function gameMenu() {
    showMenu();

    startBtn.setAttribute('onclick', 'showImg(currentImg)');
}

gameMenu();

/* * * * * * * * * * * * */