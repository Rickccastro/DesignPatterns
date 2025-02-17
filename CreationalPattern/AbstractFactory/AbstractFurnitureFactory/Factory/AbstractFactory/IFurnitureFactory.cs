using AbstractFurnitureFactory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFurnitureFactory.Factory.AbstractFactory;
public interface IFurnitureFactory
{
    public IChair CreateChair();
    public IBed CreateBed();
    public ICoffeTable CreateCoffeTable();

}
