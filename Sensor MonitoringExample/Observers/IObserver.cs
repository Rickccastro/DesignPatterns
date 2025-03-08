using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensor_MonitoringExample.Observers;
public interface IObserver
{
    public string NameSystem { get; set; }
    public void Update(int value);  
}
