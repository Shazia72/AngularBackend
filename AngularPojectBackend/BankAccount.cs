using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace AngularPojectBackend
{
	public class BankAccount
	{
        [Key]
        public int accountId { get; set; }
        public string transType { get; set; } = null;
        public int balance { get; set; }
        public string location { get; set; } = null;
        public string monthlyFee { get; set; } = null;
        public string transactionFee { get; set; } = null;
		public string eTransfer { get; set; } = null;
		public int minBalance { get; set; }
        public string interestCalculated { get; set; } = null;
		public string interestPaid { get; set; } = null;
		public string insurance { get; set; } = null;
		public string notes { get; set; } = null;
		public string lender { get; set; } = null;
		public string lenderLogo { get; set; } = null;
		//public int ROI { get; set; }
        public int rate { get; set; }
        public string website { get; set; } = null;
	}
}
