using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursologV2
{
    public interface ICRUDForm
    {
        void updateView();
        void insertRow();
        void deleteRow();
        void updateRow();
        void updateInputs();
        void clearInputs();
        bool isIncorrectModel();
        bool isIncorrectInputs();
    }
}
