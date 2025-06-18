# ControleDeBar

![](https://imgur.com/Uf01pYw.gif)

## 1. M�dulo de Mesas
### Requisitos Funcionais
- O sistema deve permitir a inser��o de novas mesas.
- O sistema deve permitir a edi��o de mesas j� cadastradas.
- O sistema deve permitir excluir mesas j� cadastradas.
- O sistema deve permitir visualizar mesas cadastradas.
- O sistema deve permitir visualizar os detalhes de cada mesa.
- O sistema deve permitir visualizar o status atual da mesa (livre/ocupada).

### Regras de Neg�cio
- **Campos obrigat�rios:**
  - N�mero (�nico, n�mero positivo).
  - Quantidade de Lugares (n�mero positivo).
- **Status poss�veis:** Livre / Ocupada.
- Ao cadastrar, o status padr�o � "Livre".
- N�o permitir cadastrar uma mesa com n�meros duplicados.
- N�o permitir excluir uma mesa caso tenha pedidos vinculados.

---

## 2. M�dulo de Gar�ons
### Requisitos Funcionais
- O sistema deve permitir a inser��o de novos gar�ons.
- O sistema deve permitir a edi��o de gar�ons j� cadastrados.
- O sistema deve permitir excluir gar�ons j� cadastrados.
- O sistema deve permitir visualizar gar�ons cadastrados.

### Regras de Neg�cio
- **Campos obrigat�rios:**
  - Nome (m�nimo 3 caracteres, m�ximo 100).
  - CPF (formato validado: XXX.XXX.XXX-XX).
- N�o pode haver gar�ons com o mesmo CPF.
- N�o permitir cadastrar um gar�om com nome e CPF duplicados.
- N�o permitir excluir um gar�om caso tenha pedidos vinculados.

---

## 3. M�dulo de Produtos
### Requisitos Funcionais
- O sistema deve permitir a inser��o de novos produtos.
- O sistema deve permitir a edi��o de produtos j� cadastrados.
- O sistema deve permitir excluir produtos j� cadastrados.
- O sistema deve permitir visualizar produtos cadastrados.

### Regras de Neg�cio
- **Campos obrigat�rios:**
  - Nome (m�nimo 2 caracteres, m�ximo 100).
  - Pre�o (n�mero positivo com 2 casas decimais).
- N�o permitir excluir um produto caso tenha pedidos vinculados.
- N�o permitir cadastrar um produto com nome duplicado.

---

## 4. M�dulo de Conta
### Requisitos Funcionais
- O sistema deve permitir abrir contas para os clientes fazerem pedidos.
- O sistema deve permitir adicionar itens a um pedido existente.
- O sistema deve permitir remover itens de um pedido existente.
- O sistema deve permitir visualizar faturamento di�rio.
- O sistema deve permitir visualizar contas em aberto.
- O sistema deve permitir visualizar contas fechadas.
- O sistema deve permitir fechar pedidos.

### Regras de Neg�cio
- **Campos obrigat�rios na abertura de contas:**
  - Nome do cliente.
  - Mesa (sele��o obrigat�ria entre mesas cadastradas).
  - Gar�om (sele��o obrigat�ria entre gar�ons cadastrados).
- **Campos obrigat�rios no registro de pedidos:**
  - Itens (lista de produtos com quantidade).
- **Status poss�veis da conta:** Aberta / Fechada.
- Ao registrar, o status padr�o � "Aberta".
- Deve calcular automaticamente o valor total de cada pedido.
- Deve calcular automaticamente o valor total faturado no dia.
- Cada mesa s� pode ter um pedido ativo por vez.

## Tecnologia

[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,git,github,visualstudio,)](https://skillicons.dev)
