 try
        {
            Fornecedor fornecedor = new Fornecedor("Fornecedor ABC", 100.00m);

            fornecedor.ExibirDetalhes();

            decimal valorProduto = 150.00m;
            if (fornecedor.PodeFornecer(valorProduto))
            {
                Console.WriteLine($"O fornecedor pode fornecer o produto de valor {valorProduto:C}.");
            }
            else
            {
                Console.WriteLine($"O fornecedor NÃO pode fornecer o produto de valor {valorProduto:C}.");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message); 
        }