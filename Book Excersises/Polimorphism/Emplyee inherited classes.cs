using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm_znowu
{
    /*
     * 
     * 
     * 
     * EMPLOYEE
     * 
     * 
     */ 

    abstract class Employee
    {
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }

        public Employee() { Name = "";IdentificationNumber = ""; }
        public Employee(string _Name, string _IdentificationNumber) { Name = _Name;IdentificationNumber = _IdentificationNumber; }
    }

    class ProductionWorker: Employee
    {
        public enum Shift {None=0,Day=1, Night=2 }

        public Shift ShiftNumber { get; set; }
        public int HourlyRate { get; set; }

        public ProductionWorker(): base() { ShiftNumber = Shift.None; HourlyRate = 0; }
        public ProductionWorker(string Name, string IDNum, Shift shiftNum, int hourlyrate): base(Name, IDNum) { ShiftNumber = shiftNum; HourlyRate = hourlyrate; }
    }

    class ShiftSupervisor: Employee
    {
        public int Salary { get; set; }
        public int Bonus { get; set; }

        public ShiftSupervisor():base() { Salary = 0; Bonus = 0; }
        public ShiftSupervisor(string Name, string IDNum, int salary, int bonus): base(Name, IDNum) { Salary = salary; Bonus = bonus; }
    }

    class TeamLeader: ProductionWorker
    {
        public int MonthlyAllowance { get; set; }
        public int RequiredTrainingHours { get; set; }
        public int TrainingHoursCompleted { get; set; }

        public TeamLeader() : base() { MonthlyAllowance = 0;RequiredTrainingHours = 0;TrainingHoursCompleted = 0; }
        public TeamLeader(string Name, string IDNUm, Shift ShiftNum, int HourlyRate, int _MonthluAllowance, int _RequiredTrainingHours, int _TrainingHoursCompleted)
            :base(Name, IDNUm, ShiftNum, HourlyRate) { MonthlyAllowance = _MonthluAllowance;RequiredTrainingHours = _RequiredTrainingHours;TrainingHoursCompleted = _TrainingHoursCompleted; }
    }
    /*
 * 
 * 
 * 
 * /EMPLOYEE
 * 
 * 
 */

}
