using System;

namespace State
{
    internal class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }

    }
