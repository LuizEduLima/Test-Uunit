using System;

namespace ProjetoTests.Domain.Core
{
    public class DomainException:Exception
    {
        public DomainException(string mensagem):base(mensagem)
        {

        }
    }
}
