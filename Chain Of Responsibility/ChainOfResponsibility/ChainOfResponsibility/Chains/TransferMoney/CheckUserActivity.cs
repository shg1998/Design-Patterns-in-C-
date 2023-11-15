using ChainOfResponsibility.Dtos;

namespace ChainOfResponsibility.Chains.TransferMoney
{
    internal class CheckUserActivity : MainTransferMoneyChain
    {
        public CheckUserActivity(MainTransferMoneyChain? transferMoneyChain) : base(transferMoneyChain) { }

        public override ResponseDto Execute(RequestDto request)
        {
            if (request.FromCustomer!.IsActive == true && request.ToCustomer!.IsActive == true)
                return this.Successor.Execute(request);
            return new ResponseDto
            {
                Message = "User Is Not Active!"
            };
        }
    }
}
