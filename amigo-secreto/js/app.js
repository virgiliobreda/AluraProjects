let arrayDeAmigos = []

function adicionar(){
    amigo = document.getElementById('nome-amigo');
    if(arrayDeAmigos.includes(amigo.value)){
        alert('Amigo ja cadastrado');
        amigo.value = '';
        return;
    }
    if(amigo.value == ''){
        alert('Informe o nome do amigo');
        return;
    }
    
    listaDeAmigos = document.getElementById('lista-amigos');
    arrayDeAmigos.push(amigo.value);
    if (listaDeAmigos.textContent == ''){
        listaDeAmigos.textContent = amigo.value;
    }
    else{
        listaDeAmigos.textContent = listaDeAmigos.textContent + ', ' + amigo.value;
    }
    amigo.value = '';
}
function sortear(){
    
    if(arrayDeAmigos.length >= 4){
        embaralha(arrayDeAmigos);
        let sorteio = document.getElementById('lista-sorteio');
        for (let i = 0; i < arrayDeAmigos.length; i++){
        if(i == arrayDeAmigos.length - 1){
            sorteio.innerHTML = sorteio.innerHTML + arrayDeAmigos[i] + ' --> ' + arrayDeAmigos[0] + '<br>';
        }
        else{
            sorteio.innerHTML = sorteio.innerHTML + arrayDeAmigos[i] + ' --> ' + arrayDeAmigos[i + 1] + '<br>';
        }
    }}
    else{
        alert('Adicione mais amigos');
    }
    listaDeAmigos = document.getElementById('lista-amigos');
    listaDeAmigos.textContent = '';
}

function embaralha(lista){
    for (let indice = lista.length; indice; indice--){
        const indiceAleatorio = Math.floor(Math.random() * indice);
        [lista[indice - 1], lista[indiceAleatorio]] = [lista[indiceAleatorio], lista[indice -1]];
    }
}
function reiniciar(){
    listaDeAmigos = document.getElementById('lista-amigos');
    listaDeAmigos.textContent = '';
    amigo = document.getElementById('nome-amigo');
    amigo.value = '';
    sorteio = document.getElementById('lista-sorteio');
    sorteio.innerHTML = '';
    listaDeAmigos = [];
    
}

