let alugados = 1;
let devolvidos = 0;

function alterarStatus(nID){
    let n = document.getElementById(`game-${nID}`);
    let imagem = n.querySelector('.dashboard__item__img');
    let botao = n.querySelector('.dashboard__item__button');
   

    if (botao.innerHTML == 'Alugar'){
        botao.innerHTML = 'Devolver';
        botao.classList.add('dashboard__item__button--return');
        imagem.classList.add('dashboard__item__img--rented');
        alugados++;
    }
    else{
        let resposta = prompt('Você tem certeza?: (y/n)');
        if(resposta == 'y'){
            botao.innerHTML = 'Alugar';
        botao.classList.remove('dashboard__item__button--return');
        imagem.classList.remove('dashboard__item__img--rented');
        devolvidos++;
        }
        else{
            return;
        }
    }
    console.log('alugados: '+ alugados);
    console.log('devolvidos: '+ devolvidos)
}