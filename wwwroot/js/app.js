document.addEventListener('DOMContentLoaded', () => {
    //cards options
    const cardArray = [
        {
            name: 'elefante',
            img: '/img/animales/elefante.png',
        },
        {
            name: 'elefante',
            img: '/img/animales/elefante.png'
        },
        {
            name: 'gato',
            img: '/img/animales/gato.png'
        },
        {
            name: 'gato',
            img: '/img/animales/gato.png'
        },
        {
            name:'caballo',
            img:'/img/animales/caballo.png'
        },
        {
            name: 'caballo',
            img: '/img/animales/caballo.png'
        },
        {
            name: 'cebra',
            img: '/img/animales/cebra.png'
        },
        {
            name: 'cebra',
            img: '/img/animales/cebra.png'
        },
        {
            name: 'raton',
            img: '/img/animales/raton.png'
        },
        {
            name: 'raton',
            img: '/img/animales/raton.png'
        },
        {
            name: 'tortuga',
            img: '/img/animales/tortuga.png'
        },
        {
            name: 'tortuga',
            img: '/img/animales/tortuga.png'
        }
    ]

    cardArray.sort(() => 0.5 - Math.random())

    const grid = document.querySelector('.grid')
    const resultDisplay = document.querySelector('#result')
    let cardsChosen = []
    let cardsChosenId = []
    let cardsWon = []

    //create you board
    function createBoard(){
        for(let i = 0; i < cardArray.length; i++) {
            var card = document.createElement('img')
            card.setAttribute('class', 'memory-img')
            card.setAttribute('src', '/img/favicon.png')
            card.setAttribute('data-id', i)
            card.addEventListener('click', flipCard)
            grid.appendChild(card)
        }
    }

    //check for matches
    function checkForMatch() {
        const cards = document.querySelectorAll('.memory-img')
        const optionOneId = cardsChosenId[0]
        const optionTwoId = cardsChosenId[1]

        if(optionOneId == optionTwoId) {
            cards[optionOneId].setAttribute('src', '/img/favicon.png')
            cards[optionTwoId].setAttribute('src', '/img/favicon.png')
            /*alert('¡ Son iguales !')*/
        }else if(cardsChosen [0] === cardsChosen[1]) {
            alert('¡ Encontraste la carta Compañera !')
            cards[optionOneId].setAttribute('src','/img/animales/blank.png')
            cards[optionTwoId].setAttribute('src', '/img/animales/blank.png')
            cards[optionOneId].removeEventListener('click', flipCard)
            cards[optionTwoId].removeEventListener('click', flipCard)
            cardsWon.push(cardsChosen)
        }else{
            cards[optionOneId].setAttribute('src', '/img/favicon.png')
            cards[optionTwoId].setAttribute('src','/img/favicon.png')
            alert('No son iguales. ¡Intenta de Nuevo!')
        }
        cardsChosen = []
        cardsChosenId = []
        resultDisplay.textContent = cardsWon.length
        if(cardsWon.length === cardArray.length/2) {
            resultDisplay.textContent ='¡¡¡ Ganaste !!!'
        }
        /*$('.memory-img').attr('disabled', 'enabled')*/
    }

    //flip your card
    function flipCard() {
        let cardId = this.getAttribute('data-id')
        cardsChosen.push(cardArray[cardId].name)
        cardsChosenId.push(cardId)
        this.setAttribute('src', cardArray[cardId].img)
        if (cardsChosen.length === 2) {
            /*$('.memory-img').attr('disabled', 'disabled')*/
            setTimeout(checkForMatch, 250)
        }
    }

    createBoard()

})