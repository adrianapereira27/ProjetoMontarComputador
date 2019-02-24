using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Computador
    {
        public string PlacaMae { get; set; }
        public decimal PrecoPlacaMae { get; set; }
        public string Processador { get; set; }
        public decimal PrecoProcessador { get; set; }
        public string Memoria { get; set; }
        public decimal PrecoMemoria { get; set; }
        public string DiscoRigido { get; set; }
        public decimal PrecoDiscoRigido { get; set; }
        public string Monitor { get; set; }
        public decimal PrecoMonitor { get; set; }
        public decimal PrecoTotal { get; set; }
    }
    class ProdutoPreco
    {
        public string Produto { get; set; }
        public int CodProduto { get; set; }
        public int QuantOpcoes { get; set; }
        public string Opc1 { get; set; }
        public string Opc2 { get; set; }
        public string Opc3 { get; set; }
        public string Opc4 { get; set; }
		public int ProdSel { get; set; }
		public int TipoProdSel { get; set; }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Computador pc = new Computador();
                        
            pc = EscolherPecas();

            Console.Clear();

            MostrarConfiguracaoPc(pc);

            Console.ReadLine();           
        }

		public static Computador EscolherPecas()
		{
			Computador pecas = new Computador();
			ProdutoPreco preco = new ProdutoPreco();

			Console.WriteLine("Escolha as peças");
            Console.WriteLine();

            preco.Produto = "Placa mãe: ";
			preco.CodProduto = 1;
			preco.QuantOpcoes = 2;
			preco.Opc1 = "Asus";
			preco.Opc2 = "Gigabyte";
			preco.Opc3 = string.Empty;
			preco.Opc4 = string.Empty;
			preco.ProdSel = 0;
			preco.TipoProdSel = 0;
			preco = Menu(preco);
            if (preco.TipoProdSel == 1)
            {
                pecas.PlacaMae = preco.Opc1;
            }
            if (preco.TipoProdSel == 2)
            {
                pecas.PlacaMae = preco.Opc2;
            }
			pecas.PrecoPlacaMae = PrecoProduto(preco.ProdSel, preco.TipoProdSel);

			preco.Produto = "Processador: ";
			preco.CodProduto = 2;
			preco.QuantOpcoes = 3;
			preco.Opc1 = "I3";
			preco.Opc2 = "I5";
			preco.Opc3 = "I7";
			preco.Opc4 = string.Empty;
			preco.ProdSel = 0;
			preco.TipoProdSel = 0;
			preco = Menu(preco);
            if (preco.TipoProdSel == 1)
            {
                pecas.Processador = preco.Opc1;
            }
            if (preco.TipoProdSel == 2)
            {
                pecas.Processador = preco.Opc2;
            }
            if (preco.TipoProdSel == 3)
            {
                pecas.Processador = preco.Opc3;
            }
            pecas.PrecoProcessador = PrecoProduto(preco.ProdSel, preco.TipoProdSel);

			preco.Produto = "Memória: ";
			preco.CodProduto = 3;
			preco.QuantOpcoes = 4;
			preco.Opc1 = "2GB";
			preco.Opc2 = "4GB";
			preco.Opc3 = "8GB";
			preco.Opc4 = "16GB";
			preco.ProdSel = 0;
			preco.TipoProdSel = 0;
			preco = Menu(preco);
            if (preco.TipoProdSel == 1)
            {
                pecas.Memoria = preco.Opc1;
            }
            if (preco.TipoProdSel == 2)
            {
                pecas.Memoria = preco.Opc2;
            }
            if (preco.TipoProdSel == 3)
            {
                pecas.Memoria = preco.Opc3;
            }
            if (preco.TipoProdSel == 4)
            {
                pecas.Memoria = preco.Opc4;
            }            
			pecas.PrecoMemoria = PrecoProduto(preco.ProdSel, preco.TipoProdSel);

			preco.Produto = "Disco rígido: ";
			preco.CodProduto = 4;
			preco.QuantOpcoes = 3;
			preco.Opc1 = "Seagate";
			preco.Opc2 = "Samsung";
			preco.Opc3 = "Dell";
			preco.Opc4 = string.Empty;
			preco.ProdSel = 0;
			preco.TipoProdSel = 0;
			preco = Menu(preco);
            if (preco.TipoProdSel == 1)
            {
                pecas.DiscoRigido = preco.Opc1;
            }
            if (preco.TipoProdSel == 2)
            {
                pecas.DiscoRigido = preco.Opc2;
            }
            if (preco.TipoProdSel == 3)
            {
                pecas.DiscoRigido = preco.Opc3;
            }            
			pecas.PrecoDiscoRigido = PrecoProduto(preco.ProdSel, preco.TipoProdSel);

			preco.Produto = "Monitor: ";
			preco.CodProduto = 5;
			preco.QuantOpcoes = 3;
			preco.Opc1 = "LCD";
			preco.Opc2 = "LED";
			preco.Opc3 = "CLR";
			preco.Opc4 = string.Empty;
			preco.ProdSel = 0;
			preco.TipoProdSel = 0;
			preco = Menu(preco);
            if (preco.TipoProdSel == 1)
            {
                pecas.Monitor = preco.Opc1;
            }
            if (preco.TipoProdSel == 2)
            {
                pecas.Monitor = preco.Opc2;
            }
            if (preco.TipoProdSel == 3)
            {
                pecas.Monitor = preco.Opc3;
            }            
			pecas.PrecoMonitor = PrecoProduto(preco.ProdSel, preco.TipoProdSel);

            pecas.PrecoTotal = pecas.PrecoPlacaMae + pecas.PrecoProcessador + pecas.PrecoMemoria + pecas.PrecoDiscoRigido + pecas.PrecoMonitor;

            return pecas;
		}

		public static ProdutoPreco Menu(ProdutoPreco prodPreco)
        {     
            int opcao = 0;           
            Console.WriteLine("Escolha " + prodPreco.Produto);
            switch (prodPreco.QuantOpcoes)
	        {
                case 1:
                    Console.WriteLine("Opção 1 - " + prodPreco.Opc1);
                    break;
                case 2:
                    Console.WriteLine("Opção 1 - " + prodPreco.Opc1);
                    Console.WriteLine("Opção 2 - " + prodPreco.Opc2);
                    break;
                case 3:
                    Console.WriteLine("Opção 1 - " + prodPreco.Opc1);
                    Console.WriteLine("Opção 2 - " + prodPreco.Opc2);
                    Console.WriteLine("Opção 3 - " + prodPreco.Opc3);
                    break;
                case 4:
                    Console.WriteLine("Opção 1 - " + prodPreco.Opc1);
                    Console.WriteLine("Opção 2 - " + prodPreco.Opc2);
                    Console.WriteLine("Opção 3 - " + prodPreco.Opc3);
                    Console.WriteLine("Opção 4 - " + prodPreco.Opc4);
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
	        }
            opcao = Convert.ToInt32(Console.ReadLine());
            prodPreco.ProdSel = opcao;
            prodPreco.TipoProdSel = opcao;

            return prodPreco;
        }

        public static decimal PrecoProduto(int produtoSel, int tipoProdutoSel)
        {
            decimal preco = 0;
            switch (produtoSel)
            {
                case 1:
                    switch (tipoProdutoSel)
                    {
                        case 1:
                            preco = 100m;
                            break;
                        case 2:
                            preco = 105.50m;
                            break;                        
                    } 
                    break;
                case 2:
                    switch (tipoProdutoSel)
                    {
                        case 1:
                            preco = 150m;
                            break;
                        case 2:
                            preco = 250m;
                            break;
                        case 3:
                            preco = 349.90m;
                            break;
                    } 
                    break;
                case 3:
                    switch (tipoProdutoSel)
                    {
                        case 1:
                            preco = 99.90m;
                            break;
                        case 2:
                            preco = 148.80m;
                            break;
                        case 3:
                            preco = 299.90m;
                            break;
                        case 4:
                            preco = 394.87m;
                            break;
                    } 
                    break;
                case 4:
                    switch (tipoProdutoSel)
                    {
                        case 1:
                            preco = 200m;
                            break;
                        case 2:
                            preco = 300m;
                            break;
                        case 3:
                            preco = 999.90m;
                            break;
                    } 
                    break;
                case 5:
                    switch (tipoProdutoSel)
                    {
                        case 1:
                            preco = 400m;
                            break;
                        case 2:
                            preco = 399.95m;
                            break;
                        case 3:
                            preco = 79.92m;
                            break;
                    }
                    break;                
            }                        
            return preco;
        }
		        
        public static void MostrarConfiguracaoPc(Computador c)
        {            
            Console.WriteLine("Configuração do Computador");
            Console.WriteLine();
            Console.WriteLine("Placa Mãe: " + c.PlacaMae + " no valor de R$ " + c.PrecoPlacaMae);
            Console.WriteLine("Processador: " + c.Processador + " no valor de R$ " + c.PrecoProcessador);
            Console.WriteLine("Memória: " + c.Memoria + " no valor de R$ " + c.PrecoMemoria);
            Console.WriteLine("Disco Rígido: " + c.DiscoRigido + " no valor de R$ " + c.PrecoDiscoRigido);
            Console.WriteLine("Monitor: " + c.Monitor + " no valor de R$ " + c.PrecoMonitor);
            Console.WriteLine();
            Console.WriteLine("Valor Total: " + c.PrecoTotal);
        }
    }
}
