function inserirRoteiro() {
    // Obter valores do formulário
    const imagemUrl = document.getElementById('imagemUrl').value;
    const destino = document.getElementById('destino').value;
    const diarias = document.getElementById('diarias').value;
    const preco = document.getElementById('preco').value;

    // Criar elemento div com a classe roteiro-viagens
    const novoRoteiro = document.createElement('div');
    novoRoteiro.className = 'roteiros-viagens';

    // Criar estrutura interna para o novo roteiro
    novoRoteiro.innerHTML = `
        <img src="${imagemUrl}" class="postal">
        <div class="roteiro-destino">${destino}</div>
        <ul class="roteiro-incluso">
            <li>Áereo ida e volta</li>
            <li>${diarias} diárias</li>
            <li>Café da Manhã</li>
        </ul>
        <div class="roteiro-preco">${preco}</div>
        <div class="roteiro-obs">Taxas Inclusas</div>
        <div class="roteiro-parcelamento">Em até 10x sem Juros</div>
        <button class="roteiro-comprar">Comprar</button>`;

    // Adicionar o novo roteiro à classe container-destinos
    const containerDestinos = document.querySelector('.container-destinos');
    containerDestinos.appendChild(novoRoteiro);

    // Limpar valores do formulário após a inserção
    document.getElementById('imagemUrl').value = '';
    document.getElementById('destino').value = '';
    document.getElementById('diarias').value = '';
    document.getElementById('preco').value = '';
}