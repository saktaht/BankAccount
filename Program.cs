namespace SelfCSharp.Chap01
{ 
    internal class BankAccount
    {
        public long accountNumber;//口座番号
        public string ownerName;//
        public long blance;//現在の残高
        public int add;//増する金額
        public int sub;//減る金額

        public BankAccount(long accountNumber, string ownerName, long blance,int add, int sub)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.blance = blance;
            this.add = add;
            this.sub = sub;
        }

        //現在の残高を表示
        public long GetBalance()
        {
            return blance;
        }

        //貯金する
        public void Deposit()
        {
            blance += add;
        }
        //お金を引き出す
        public void Withdraw()
        {
            blance -= sub;
        }

    }

    internal class PersonClient
    {
        static void Main(string[] args)
        {
            var bank = new BankAccount(4168416927, "坂本龍馬", 1000000000000,10,10000);
            bank.Deposit();
            Console.WriteLine($"貯金後の残高は{bank.GetBalance()}です。");
            bank.Withdraw();
            Console.WriteLine($"貯金後の残高は{bank.GetBalance()}です。");




        }
    }
}
