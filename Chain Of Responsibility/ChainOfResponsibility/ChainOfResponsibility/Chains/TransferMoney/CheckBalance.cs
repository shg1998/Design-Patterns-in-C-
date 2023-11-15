using ChainOfResponsibility.Dtos;

namespace ChainOfResponsibility.Chains.TransferMoney
{
    internal class CheckBalance : MainTransferMoneyChain
    {
        public CheckBalance(MainTransferMoneyChain? transferMoneyChain) : base(transferMoneyChain) { }

        public override ResponseDto Execute(RequestDto request)
        {
            if (request.FromCustomer!.AccountValue >= request.Value)
                return this.Successor.Execute(request);
            return new ResponseDto
            {
                Message = "No Balance!"
            };
        }
    }
}
