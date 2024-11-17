function comprar(){
    let quantidade = parseInt(document.getElementById('qtd').value);
    let tipo = document.getElementById('tipo-ingresso');
    console.log(tipo);
    console.log(quantidade);
    if (tipo.value === 'pista'){
        comprarPista(quantidade);
    }
    else if (tipo.value == 'inferior'){
        comprarInferior(quantidade);
    }
    else if (tipo.value == 'superior'){
        comprarSuperior(quantidade);
    }
   
}

function comprarPista(qtd){
    let qtdPista = parseInt(document.getElementById("qtd-pista").textContent);
    if (qtd > qtdPista){
        alert('Quantidade indisponível');
    }
    else{
        qtdPista = qtdPista - qtd;
        document.getElementById("qtd-pista").textContent = `${qtdPista}`;
        alert('Compra realizada com sucesso');
    }
}

function comprarInferior(qtd){
    
    let qtdInferior = parseInt(document.getElementById('qtd-inferior').textContent);

    if(qtd > qtdInferior){
        alert('Quantidade indisponível');
    }else{
        qtdInferior -= qtd;
        document.getElementById('qtd-inferior').textContent = qtdInferior;
        alert('Compra realizada com sucesso');
    }   
}

function comprarSuperior(qtd){
    
    let qtdSuperior = document.getElementById('qtd-superior').textContent;
    if( qtd > qtdSuperior){
        alert('Quantidade indisponível');
    }
    else{
        qtdSuperior -= qtd;
        document.getElementById('qtd-superior').textContent = qtdSuperior;
        alert('Compra realizada com sucesso');
    }
}