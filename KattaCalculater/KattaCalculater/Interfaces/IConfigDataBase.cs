using System;
using System.Collections.Generic;
using System.Text;

namespace KattaCalculater.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
