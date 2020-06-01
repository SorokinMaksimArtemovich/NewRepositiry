// Класс, хранящий данные сотрудника, используемый в качестве буферва для данных сотрудника и для передачи данных в функции


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfEmployee_sData
{
    public class Employee
    {
        // Данные сотрудника
        public uint ID { get; }
        public string Name { get; }
        public string LastName { get; }
        public string MiddleName { get; }
        public DateTime BirthDate { get; }
        public string Address { get; }
        public string Department { get; }
        public string DescriptionOfYourself { get; }
        // Создание экземпляра без ID, но с отчеством, используемый при добавлении сотрудника в БД
        public Employee(string NameOfEmployee, string LastNameOfEmployee, string MiddleNameOfEmployee, DateTime BirthDateOfEmployee, string AddressOfEmployee, string DepartmentOfEmployee, string DescriptionOfEmployee)
        {
            Name = NameOfEmployee;
            LastName = LastNameOfEmployee;
            MiddleName = MiddleNameOfEmployee;
            BirthDate = BirthDateOfEmployee;
            Address = AddressOfEmployee;
            Department = DepartmentOfEmployee;
            DescriptionOfYourself = DescriptionOfEmployee;
        }
        // Создание экземпляра без ID и без отчества, используемый при добавлении сотрудника в БД
        public Employee(string NameOfEmployee, string LastNameOfEmployee, DateTime BirthDateOfEmployee, string AddressOfEmployee, string DepartmentOfEmployee, string DescriptionOfEmployee)
        {
            Name = NameOfEmployee;
            LastName = LastNameOfEmployee;
            MiddleName = "";
            BirthDate = BirthDateOfEmployee;
            Address = AddressOfEmployee;
            Department = DepartmentOfEmployee;
            DescriptionOfYourself = DescriptionOfEmployee;
        }
        // Создание экземпляра с ID и с отчеством, используемый при действиях с БД (кроме добаления сотрудника) и в качестве буфера
        public Employee(uint Id, string NameOfEmployee, string LastNameOfEmployee, string MiddleNameOfEmployee, DateTime BirthDateOfEmployee, string AddressOfEmployee, string DepartmentOfEmployee, string DescriptionOfEmployee)
        {
            ID = Id;
            Name = NameOfEmployee;
            LastName = LastNameOfEmployee;
            MiddleName = MiddleNameOfEmployee;
            BirthDate = BirthDateOfEmployee;
            Address = AddressOfEmployee;
            Department = DepartmentOfEmployee;
            DescriptionOfYourself = DescriptionOfEmployee;
        }
        // Создание экземпляра с ID, но без отчеством, используемый при действиях с БД (кроме добаления сотрудника) и в качестве буфера
        public Employee(uint Id, string NameOfEmployee, string LastNameOfEmployee, DateTime BirthDateOfEmployee, string AddressOfEmployee, string DepartmentOfEmployee, string DescriptionOfEmployee)
        {
            ID = Id;
            Name = NameOfEmployee;
            LastName = LastNameOfEmployee;
            MiddleName = "";
            BirthDate = BirthDateOfEmployee;
            Address = AddressOfEmployee;
            Department = DepartmentOfEmployee;
            DescriptionOfYourself = DescriptionOfEmployee;
        }
    }
}
