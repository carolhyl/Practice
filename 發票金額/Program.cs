using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 發票金額
{
	internal class Program
	{
			static void Main(string[] args)
			{
				Invoice result = new Invoice(500);
				Console.WriteLine($"未稅價:{result.Price},稅值:{result.Tax},含稅價:{result.InclusivePrice}");
			}
			public class Invoice
			{
				public int Price { get; set; }
				public int Tax { get; private set; }
				public int InclusivePrice { get; }

				public Invoice(int price, double taxRate = 0.05)
				{
					this.Price = price;
					Tax = (int)Math.Round(price * taxRate, MidpointRounding.AwayFromZero);
					InclusivePrice = Price + Tax;
				}
			}
			public class Estore : Invoice
			{
				public Estore(int price, double taxRate = 0.05) : base(price, taxRate)
				{
					Console.WriteLine(); //怎麼呼叫下面兩隻method進來建構函數
				}

				private int CalcuPrice(int price)
				{
					return Price * Tax;
				}

				//Invoicet issue = new Invoicet();
				public Invoicet IssueInvoice(int price)

			{
				//var event1 = Invoicet.IssueInvoice();
				return Invoicet.IssueInvoice(); //怎麼呼叫外部class Invoicet 的 IssueInvoice method
			}
		}

			class Invoicet
			{
				public string IssueInvoice(int price)
				{
					string invoice = $"這是你的發票,金額:{price}";
					return invoice;
				}
			}
		
	}
}
