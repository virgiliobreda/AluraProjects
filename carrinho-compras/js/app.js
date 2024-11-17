let totalGeralSemTratamento = document.getElementById('valor-total').innerHTML = 'R$ 0';
let totalGeral = parseFloat(totalGeralSemTratamento.split('$')[1]);
listaProduto = document.getElementById('lista-produtos').innerHTML = '';


function adicionar(){
    let produto = document.getElementById('produto').value;
    let quantidade = document.getElementById('quantidade').value;
    let nomeProduto = produto.split('-')[0];
    let valorUnitario = produto.split('$')[1];
    
    
    let subtotal = quantidade * valorUnitario;

    if (quantidade <= 0){
        alert('Digite uma quantidade válida.')
    }
    else{

    listaProduto = document.getElementById('lista-produtos');
    
    listaProduto.innerHTML = listaProduto.innerHTML +
    `
    <section class="carrinho__produtos__produto">
    <span class="texto-azul">${quantidade}x </span>${nomeProduto}<span class="texto-azul">R$ ${valorUnitario}</span>
    </section>
    `
    totalGeral += subtotal;

    let valorTotal = document.getElementById('valor-total');
    valorTotal.innerText = `R$ ${totalGeral}`;
    }

    quantidade = document.getElementById('quantidade').value = 0;
      
}


function limpar(){
    totalGeralSemTratamento = document.getElementById('valor-total').innerHTML = 'R$ 0';
    totalGeral = 0;
    listaProduto = document.getElementById('lista-produtos').innerHTML = '';
    quantidade = document.getElementById('quantidade').value = 0;
}