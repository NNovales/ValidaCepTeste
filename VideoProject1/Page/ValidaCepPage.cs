using VideoProject.Core;

namespace VideoProject.Page
{
    class ValidaCepPage : Begin
    {
        public void PreencheCep()
        {
            EscreveTexto("//*[@id='endereco']", "46600000");
        }

        public void ClicaBtnBusca()
        {
            ClicaElemento("//*[@id='btn_pesquisar']");
        }

        public void ValidaResultado()
        {
            ValidaDados("//*[@id=\"resultado-DNEC\"]/tbody/tr/td[3]", "Tanhaçu/BA");
        }
    }
}
