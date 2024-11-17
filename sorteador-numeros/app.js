let sorteados = [];

function sortear(){
    let quantidadeDeNumeros = parseInt(document.getElementById('quantidade').value);
    let deNum = parseInt(document.getElementById('de').value);
    let ate = parseInt(document.getElementById('ate').value);
    
    let numero;

    if (isNaN(quantidadeDeNumeros) || isNaN(deNum)|| isNaN(ate)){
        alert('Insira os dados corretamente');
        return;
    }
    if (quantidadeDeNumeros > (ate - deNum + 1)){
        alert('Quantidade deve ser menor do que o intervalo informado');
        reiniciar();
        return;
    }

    if (deNum <= ate){
        for(let i = 0; i < quantidadeDeNumeros; i++){
            numero = obterNumeroAleatorio(deNum, ate);
            while(sorteados.includes(numero)){
            numero = obterNumeroAleatorio(deNum, ate);
        }

        sorteados.push(numero);
    }
}
    else{
        alert('O número minimo é maior que o número máximo')
        reiniciar();
    }
    
    sorteados.sort();
    exibirNaTela();
    alterarBotao();
}

function obterNumeroAleatorio(min, max){
    return parseInt(Math.random() * (max - min + 1) + min);
}

function exibirNaTela(){
    let resultado = document.getElementById('resultado');
    resultado.innerHTML = `<label class="texto__paragrafo">Números sorteados: ${sorteados}</label>`;
}

function reiniciar(){
    sorteados = [];
    document.getElementById('de').value = '';
    document.getElementById('ate').value = '';
    document.getElementById('quantidade').value = '';
    document.getElementById('resultado').value = '';
    let resultado = document.getElementById('resultado');
    resultado.innerHTML = '<label class="texto__paragrafo">Números sorteados:  nenhum até agora</label>';
    alterarBotao();
}

function alterarBotao(){
    let botao = document.getElementById('btn-reiniciar');

    if (botao.classList.contains('container__botao-desabilitado')){
    botao.classList.remove('container__botao-desabilitado');
    botao.classList.add('container__botao');
    }
    else{
        botao.classList.remove('container__botao');
        botao.classList.add('container__botao-desabilitado');
    }   
}

