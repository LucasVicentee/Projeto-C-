using AgregacaoVenda;

Produto prod1 = new Produto(1, "xampu", 10.00);
Produto prod2 = new Produto(2, "Sabonete", 2.50);
Produto prod3 = new Produto(3, "Pasta de dente", 5.25);
Produto prod4 = new Produto(4, "Escova", 4.50);

Comprador comp = new Comprador(100);
Vendedor vend = new Vendedor();

Venda v = new Venda(comp, vend);
v.VetProduto = new List<Produto>();
v.VetProduto.Add(prod1);
v.VetProduto.Add(prod2);
v.VetProduto.Add(prod3);
v.VetProduto.Add(prod4);

v.RealizarVenda();
v.MostrarAtributos();