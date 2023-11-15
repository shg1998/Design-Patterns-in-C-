using ChainOfResponsibility.Dtos;

namespace ChainOfResponsibility.Chains
{
    internal abstract class MainTransferMoneyChain
    {
        protected readonly MainTransferMoneyChain? Successor;
        protected MainTransferMoneyChain(MainTransferMoneyChain? transferMoneyChain) =>
            this.Successor = transferMoneyChain;
        public abstract ResponseDto Execute(RequestDto request);
    }
}
