using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFurnitureFactory.Domain.Interfaces;
public interface IChair
{
    string Name { get; }
    public void SitOn();
    public void StepOn();
}
