using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFurnitureFactory.Domain.Interfaces;
public interface ICoffeTable
{
    string Name { get; }
    public void FeetOnTable();
    public void FeetOffTable();
    public void CoffeOnTable();
    public void CoffeOffTable();
}
