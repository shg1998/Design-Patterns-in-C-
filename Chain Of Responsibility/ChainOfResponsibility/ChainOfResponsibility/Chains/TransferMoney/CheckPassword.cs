using ChainOfResponsibility.Dtos;

namespace ChainOfResponsibility.Chains.TransferMoney
{
    internal class CheckPassword : MainTransferMoneyChain
    {
        public CheckPassword(MainTransferMoneyChain? transferMoneyChain) : base(transferMoneyChain) { }

        public override ResponseDto Execute(RequestDto request)
        {
            if (request.Password == request.FromCustomer!.Password)
                return this.Successor.Execute(request);
            return new ResponseDto
            {
                Message = "Password is incorrect!"
            };
        }
    }
}
