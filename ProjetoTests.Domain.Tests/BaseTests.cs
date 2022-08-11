using Microsoft.Extensions.DependencyInjection;
using ProjetoTests.Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTests.Domain.Tests
{
    public abstract class BaseTests
    {
    }

    public class DbTest : IDisposable
    {
        string dataBasename = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", "")}";

        public ServiceProvider provider { get; private set; }
        public DbTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
