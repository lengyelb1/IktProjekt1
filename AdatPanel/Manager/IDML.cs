using AdatPanel.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdatPanel.MainWindow;

namespace Server.DatabaseManager
{
    public interface IDML
    {
        List<Record> Select();
    }
}
