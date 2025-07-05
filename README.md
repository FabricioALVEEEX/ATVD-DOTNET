<h1>🍔 MacLanche Feliz do Fabrício</h1>

<p>Projeto de uma lanchonete com CRUD completo de produtos desenvolvido em <strong>ASP.NET Core MVC</strong> com <strong>SQLite</strong>.</p>

<h2>🚀 Funcionalidades</h2>
<ul>
  <li>Cadastrar produtos (nome e preço)</li>
  <li>Listar produtos no cardápio</li>
  <li>Editar produtos</li>
  <li>Excluir produtos</li>
  <li>Validação de campos com formatação correta de preço (ex: 2.60)</li>
</ul>

<h2>💻 Tecnologias Utilizadas</h2>
<ul>
  <li>ASP.NET Core MVC</li>
  <li>Entity Framework Core</li>
  <li>SQLite</li>
  <li>Bootstrap 5 (layout)</li>
  <li>C#</li>
</ul>

<h2>🗂️ Estrutura do Projeto</h2>
<pre>
MacLancheFelizFabricio/
│
├── Controllers/
│   └── ProdutosController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Models/
│   └── Produto.cs
│
├── Views/
│   ├── Home/
│   │   └── Index.cshtml (com botão Ver Cardápio)
│   └── Produtos/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
│
├── wwwroot/
│   └── (estáticos e layout)
│
└── Program.cs (configuração do EF Core e SQLite)
</pre>

<h2>⚙️ Como Rodar o Projeto</h2>

<ol>
  <li>Clone o repositório:
    <pre><code>git clone https://github.com/seuusuario/maclanchefeliz.git
cd maclanchefeliz</code></pre>
  </li>

  <li>Restaure os pacotes:
    <pre><code>dotnet restore</code></pre>
  </li>

  <li>Crie o banco e aplique a migration:
    <pre><code>dotnet ef migrations add InitialCreate
dotnet ef database update</code></pre>
  </li>

  <li>Execute a aplicação:
    <pre><code>dotnet run</code></pre>
  </li>
</ol>
