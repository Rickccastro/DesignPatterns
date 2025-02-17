using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFurnitureFactory.Domain.Interfaces;
public interface IBed
{
    string Name { get; }
    public void SleepOnBed();
    public void SitOnBed();
}
