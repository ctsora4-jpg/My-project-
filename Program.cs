
}using System;

namespace Inheritance
{
    class Appliance
    {
        protected int DeviceID;
        protected string CustomerName;
        protected string FaultDescription;

        public double RepairCost { get; set; }

        // Constructor
        public Appliance(int id, string name, string fault)
        {
            DeviceID = id;
            CustomerName = name;
            FaultDescription = fault;
        }

        // Method for displaying device information
        public void PrintInfo()
        {
            Console.WriteLine("Device ID: " + DeviceID);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Fault: " + FaultDescription);
        }

        // Method for calculating repair cost
        public virtual double CalculateRepairCost()
        {
            return RepairCost;
        }
    