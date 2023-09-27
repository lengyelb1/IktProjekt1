using AdatPanel.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseManager
{
    public interface IDQL
    {
        string Insert(Record record);

        string Update(Record record);

        string Delete(Record record);
    }
}
