// Crie um arquivo .ts para o seu script TypeScript, por exemplo, script.ts

// Função para fazer uma requisição à API
async function fetchData(apiUrl: string): Promise<any> {
    const response = await fetch(apiUrl);
  
    if (!response.ok) {
      throw new Error(`Erro ao buscar dados da API: ${response.statusText}`);
    }
  
    return response.json();
  }
  
  // Função para preencher os quadros "Notícias" e "Serviços"
  async function fillData() {
    try {
      // Exemplo de uso para a API de piadas
      const jokeApiUrl = 'https://v2.jokeapi.dev/joke/Any?lang=pt';
      const jokeData = await fetchData(jokeApiUrl);
  
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
  
      const apiKey = 'abba1510f71fe40dd0cd0ca7f258d1a4'; // Substitua com a sua chave de API
      const cidade = 'Ilheus'; // Substitua com o nome da cidade desejada

      const weatherApiUrl = `http://api.openweathermap.org/data/2.5/weather?q=${cidade}&appid=${apiKey}&units=metric`;
      const weatherData = await fetchData(weatherApiUrl);
  
      // Preencha o quadro de serviços com os dados obtidos
      const servicosQuadro = document.getElementById('servicos');
      if (servicosQuadro) {
        const cityName = weatherData.name;
        const temperature = weatherData.main.temp;
        const minTemperature = weatherData.main.temp_min;
        const maxTemperature = weatherData.main.temp_max;
        const description = weatherData.weather[0].description;

        const servicosHTML = `<p>Cidade: ${cityName}</p>
                              <p>Temperatura Atual: ${temperature}°C</p>
                              <p>Temperatura Mínima: ${minTemperature}°C</p>
                              <p>Temperatura Máxima: ${maxTemperature}°C</p>
                              <p>Descrição: ${description}</p>`;

        servicosQuadro.innerHTML = servicosHTML;
      }
  
    } catch (error) {
      console.error(error);
    }
  }
  
  // Execute a função para preencher os dados quando a página carregar
  document.addEventListener('DOMContentLoaded', fillData);
  
