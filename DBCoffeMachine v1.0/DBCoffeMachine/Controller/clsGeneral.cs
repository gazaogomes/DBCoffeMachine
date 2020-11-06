using System.Windows.Forms;

namespace DBCoffeMachine.Controller
{
    class clsGeneral
    {

        #region Methods
        public void ErrorInsertCoins()
        {
            MessageBox.Show("Oops! Problema na máquina, não estamos recebendo esse tipo de moeda.");
            return;
        }



        #endregion
    }
}
