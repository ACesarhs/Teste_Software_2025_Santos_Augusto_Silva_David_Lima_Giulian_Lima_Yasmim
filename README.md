# Problema com Mocks no Moq e Qualidade em Testes Unitários

**Repositório da atividade prática da disciplina COMP0444 – Teste de Software**  
Universidade Federal de Sergipe – DCOMP  

## 🔗 Link do Stack Overflow analisado

[Different return values the first and second time with Moq](https://stackoverflow.com/questions/7287540/different-return-values-the-first-and-second-time-with-moq)

## 🎯 Objetivo da Atividade

Este repositório tem como objetivo demonstrar, com base em um problema real do Stack Overflow, como a má configuração de mocks usando a biblioteca **Moq** pode comprometer a qualidade dos testes unitários.

A proposta foi:

- Reproduzir o erro apresentado na dúvida;
- Aplicar a solução correta com base na resposta aceita;
- Relacionar o problema com conceitos de qualidade de software;
- Apontar boas práticas no uso de mocks.

---

## 📘 Conceitos Abordados

- **Testes unitários**: Verificação de partes isoladas do código (métodos/funções).
- **Mocks**: Objetos simulados que imitam componentes externos em testes.
- **Moq**: Biblioteca para criação e configuração de mocks no ambiente .NET.

---

## 🛠️ Tecnologias Utilizadas

- .NET 6 ou superior
- C#
- Moq (v4.16+)
- xUnit (ou NUnit)

---

## 📂 Estrutura do Projeto

```bash
/TesteMoq
├── Interfaces/
│   └── IMyService.cs
├── Tests/
│   └── MyServiceTests.cs
├── Program.cs (opcional para testes manuais)
├── TesteMoq.csproj
└── README.md
