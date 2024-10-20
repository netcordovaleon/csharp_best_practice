using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices.DesignPatterns.Creationals
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
    }

    public class ComputerBuilder
    {
        private Computer _computer = new Computer();
        public ComputerBuilder AddCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder AddRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }
        public ComputerBuilder AddHardDisk(string hardDisk)
        {
            _computer.HardDisk = hardDisk;
            return this;
        }
        public Computer Build()
        {
            return _computer;
        }
    }
}
