using NUnit.Framework;
using VideoProject.Page;

namespace VideoProject.Test
{
    class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep()
        {
            PreencheCep();
            ClicaBtnBusca();
            ValidaResultado();
        }
    }
}
