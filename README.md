# 🚗 Sistema de Estacionamento - DIO .NET

Projeto desenvolvido como parte do desafio do Bootcamp **WEX - End to End Engineering** da [DIO](https://www.dio.me/).

---

## 📋 Descrição

Aplicação de console para simular um sistema simples de estacionamento. O usuário informa um valor inicial, um valor por hora e pode:

- Cadastrar veículos (placa)
- Listar os veículos estacionados
- Remover veículos (com cálculo do valor a pagar)

---

## 🧠 O que foi utilizado no projeto

- ✅ **C#** – Linguagem principal da aplicação
- ✅ **.NET 6 / .NET Core** – Plataforma para desenvolvimento da aplicação console
- ✅ **Programação Orientada a Objetos (POO)** – Uso de classes, métodos e encapsulamento
- ✅ **Organização em camadas** – Separação em `Models`, `Services` e `Program`
- ✅ **Coleções genéricas (`List<T>`)** – Armazenamento dos veículos em tempo de execução
- ✅ **LINQ (`Any`, `FirstOrDefault`)** – Consultas e verificações eficientes sobre listas
- ✅ **Tratamento de entrada do usuário** – Validação de dados com `TryParse` e `ToUpper`
- ✅ **Interpolação de strings** – Uso de `$"texto {variável}"` para formatação clara

---

## 📂 Estrutura do Projeto

```
EstacionamentoApp/
│
├── Models/
│ └── Veiculo.cs
│
├── Services/
│ └── Estacionamento.cs
│
├── Program.cs
├── EstacionamentoApp.csproj
```

---

## 💡 Funcionalidades

- [x] Cadastro de veículos
- [x] Listagem dos veículos
- [x] Remoção com cálculo baseado no tempo
- [x] Organização em camadas
- [x] Uso de `List<T>` para armazenar os dados

---

## 🧪 Exemplo de uso

```
Sistema de Estacionamento 🚗
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

🛠️ Como executar
Clone o projeto:

```
git clone https://github.com/seu-usuario/EstacionamentoApp.git
```

Navegue até a pasta:
```
cd EstacionamentoApp
```

Rode o projeto:
```
dotnet run
```

👩‍💻 Desenvolvido por
Enaile Vasconcelos Bezerra Lopes

🚀 Desafio proposto por
Digital Innovation One - DIO
