Cliente cliente = new Cliente("Maria", "maria@email.com", "1234-5678");
cliente.ExibirDetalhes();

Produto produto1 = new Produto("Celular", 1500.00m);
Produto produto2 = new Produto("Fone de Ouvidos", 200.00m);

Pedido pedido = new Pedido();
pedido.AdicionarProduto(produto1);
pedido.AdicionarProduto(produto2);
pedido.ExibirDetalhesPedido();

