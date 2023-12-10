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
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (g && (g = 0, op[0] && (_ = 0)), _) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
// Função para fazer uma requisição à API
function fetchData(apiUrl) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch(apiUrl)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Erro ao buscar dados da API: ".concat(response.statusText));
                    }
                    return [2 /*return*/, response.json()];
            }
        });
    });
}
// Função para preencher os quadros "Notícias" e "Serviços"
function fillData() {
    return __awaiter(this, void 0, void 0, function () {
        var jokeApiUrl, jokeData, noticiasQuadro, noticiasHTML, apiKey, cidade, weatherApiUrl, weatherData, servicosQuadro, cityName, temperature, minTemperature, maxTemperature, description, servicosHTML, error_1;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    _a.trys.push([0, 3, , 4]);
                    jokeApiUrl = 'https://v2.jokeapi.dev/joke/Any?lang=pt';
                    return [4 /*yield*/, fetchData(jokeApiUrl)];
                case 1:
                    jokeData = _a.sent();
                    noticiasQuadro = document.getElementById('menulateralcentral');
                    if (noticiasQuadro) {
                        noticiasHTML = "<h2>Not\u00EDcias</h2>\n          <ul>\n            <li>\n              <h3>".concat(jokeData.setup, "</h3>\n              <p>").concat(jokeData.delivery, "</p>\n            </li>\n          </ul>");
                        noticiasQuadro.innerHTML = noticiasHTML;
                    }
                    apiKey = 'abba1510f71fe40dd0cd0ca7f258d1a4';
                    cidade = 'Ilheus';
                    weatherApiUrl = "http://api.openweathermap.org/data/2.5/weather?q=".concat(cidade, "&appid=").concat(apiKey, "&units=metric");
                    return [4 /*yield*/, fetchData(weatherApiUrl)];
                case 2:
                    weatherData = _a.sent();
                    servicosQuadro = document.getElementById('servicos');
                    if (servicosQuadro) {
                        cityName = weatherData.name;
                        temperature = weatherData.main.temp;
                        minTemperature = weatherData.main.temp_min;
                        maxTemperature = weatherData.main.temp_max;
                        description = weatherData.weather[0].description;
                        servicosHTML = "<p>Cidade: ".concat(cityName, "</p>\n                              <p>Temperatura Atual: ").concat(temperature, "\u00B0C</p>\n                              <p>Temperatura M\u00EDnima: ").concat(minTemperature, "\u00B0C</p>\n                              <p>Temperatura M\u00E1xima: ").concat(maxTemperature, "\u00B0C</p>\n                              <p>Descri\u00E7\u00E3o: ").concat(description, "</p>");
                        servicosQuadro.innerHTML = servicosHTML;
                    }
                    return [3 /*break*/, 4];
                case 3:
                    error_1 = _a.sent();
                    console.error(error_1);
                    return [3 /*break*/, 4];
                case 4: return [2 /*return*/];
            }
        });
    });
}
// Execute a função para preencher os dados quando a página carregar
document.addEventListener('DOMContentLoaded', fillData);
