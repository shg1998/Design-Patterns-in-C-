using ChainOfResponsibility.Dtos;

namespace ChainOfResponsibility.Chains.TransferMoney
{
    internal class TransferOperationFinalizer : MainTransferMoneyChain
    {
        public TransferOperationFinalizer(MainTransferMoneyChain? transferMoneyChain) : base(transferMoneyChain) { }

        public override ResponseDto Execute(RequestDto request)
        {
            request.FromCustomer!.AccountValue -= request.Value;
            request.ToCustomer!.AccountValue += request.Value;
            return new ResponseDto
            {
                Message = "Transfer Money has been Completed!"
            };
        }
    }
}
