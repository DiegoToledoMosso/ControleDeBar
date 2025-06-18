# ControleDeBar

![](https://imgur.com/Uf01pYw.gif)

## 1. Módulo de Mesas
### Requisitos Funcionais
- O sistema deve permitir a inserção de novas mesas.
- O sistema deve permitir a edição de mesas já cadastradas.
- O sistema deve permitir excluir mesas já cadastradas.
- O sistema deve permitir visualizar mesas cadastradas.
- O sistema deve permitir visualizar os detalhes de cada mesa.
- O sistema deve permitir visualizar o status atual da mesa (livre/ocupada).

### Regras de Negócio
- **Campos obrigatórios:**
  - Número (único, número positivo).
  - Quantidade de Lugares (número positivo).
- **Status possíveis:** Livre / Ocupada.
- Ao cadastrar, o status padrão é "Livre".
- Não permitir cadastrar uma mesa com números duplicados.
- Não permitir excluir uma mesa caso tenha pedidos vinculados.

---

## 2. Módulo de Garçons
### Requisitos Funcionais
- O sistema deve permitir a inserção de novos garçons.
- O sistema deve permitir a edição de garçons já cadastrados.
- O sistema deve permitir excluir garçons já cadastrados.
- O sistema deve permitir visualizar garçons cadastrados.

### Regras de Negócio
- **Campos obrigatórios:**
  - Nome (mínimo 3 caracteres, máximo 100).
  - CPF (formato validado: XXX.XXX.XXX-XX).
- Não pode haver garçons com o mesmo CPF.
- Não permitir cadastrar um garçom com nome e CPF duplicados.
- Não permitir excluir um garçom caso tenha pedidos vinculados.

---

## 3. Módulo de Produtos
### Requisitos Funcionais
- O sistema deve permitir a inserção de novos produtos.
- O sistema deve permitir a edição de produtos já cadastrados.
- O sistema deve permitir excluir produtos já cadastrados.
- O sistema deve permitir visualizar produtos cadastrados.

### Regras de Negócio
- **Campos obrigatórios:**
  - Nome (mínimo 2 caracteres, máximo 100).
  - Preço (número positivo com 2 casas decimais).
- Não permitir excluir um produto caso tenha pedidos vinculados.
- Não permitir cadastrar um produto com nome duplicado.

---

## 4. Módulo de Conta
### Requisitos Funcionais
- O sistema deve permitir abrir contas para os clientes fazerem pedidos.
- O sistema deve permitir adicionar itens a um pedido existente.
- O sistema deve permitir remover itens de um pedido existente.
- O sistema deve permitir visualizar faturamento diário.
- O sistema deve permitir visualizar contas em aberto.
- O sistema deve permitir visualizar contas fechadas.
- O sistema deve permitir fechar pedidos.

### Regras de Negócio
- **Campos obrigatórios na abertura de contas:**
  - Nome do cliente.
  - Mesa (seleção obrigatória entre mesas cadastradas).
  - Garçom (seleção obrigatória entre garçons cadastrados).
- **Campos obrigatórios no registro de pedidos:**
  - Itens (lista de produtos com quantidade).
- **Status possíveis da conta:** Aberta / Fechada.
- Ao registrar, o status padrão é "Aberta".
- Deve calcular automaticamente o valor total de cada pedido.
- Deve calcular automaticamente o valor total faturado no dia.
- Cada mesa só pode ter um pedido ativo por vez.

## Tecnologia

[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,git,github,visualstudio,)](https://skillicons.dev)
