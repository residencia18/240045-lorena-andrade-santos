"use strict";
// Crie um arquivo .ts para o seu script TypeScript, por exemplo, script.ts
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
// Função para fazer uma requisição à API
function fetchData(apiUrl) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(apiUrl);
        if (!response.ok) {
            throw new Error(`Erro ao buscar dados da API: ${response.statusText}`);
        }
        return response.json();
    });
}
// Função para preencher os quadros "Notícias" e "Serviços"
function fillData() {
    return __awaiter(this, void 0, void 0, function* () {
        try {
            // Exemplo de uso para a API de piadas
            const jokeApiUrl = 'https://v2.jokeapi.dev/joke/Any?lang=pt';
            const jokeData = yield fetchData(jokeApiUrl);
            // Preencha os quadros de notícias com os dados obtidos
            const noticiasQuadro = document.getElementById('menulateralcentral');
            if (noticiasQuadro) {
                const noticiasHTML = `<h2>Notícias</h2>
          <ul>
            <li>
              <h3>${jokeData.setup}</h3>
              <p>${jokeData.delivery}</p>
            </li>
          </ul>`;
                noticiasQuadro.innerHTML = noticiasHTML;
            }
            // Exemplo de uso para a API de previsão do tempo (substitua pela API desejada)
            const weatherApiUrl = 'https://api.openweathermap.org/data/2.5/weather?q=uesc&appid=YOUR_API_KEY';
            const weatherData = yield fetchData(weatherApiUrl);
            // Preencha o quadro de serviços com os dados obtidos
            const servicosQuadro = document.getElementById('servicos');
            if (servicosQuadro) {
                const servicosHTML = `<p>Previsão do Tempo: ${weatherData.weather[0].description}</p>`;
                servicosQuadro.innerHTML = servicosHTML;
            }
            // Continue a adicionar chamadas de API e preencher outros quadros conforme necessário
        }
        catch (error) {
            console.error(error);
        }
    });
}
// Execute a função para preencher os dados quando a página carregar
document.addEventListener('DOMContentLoaded', fillData);
