// Статический класс обеспечивающий взаимодействие между базой данных и формами приложения


using System.Collections.Generic;
using System;

namespace ManagementOfEmployee_sData
{
    static class Service
    {
        // Создание экземпляра класса DataBaseAccessObject, вызывающее подключение или создание базы данных
        static DataBaseAccessObject DataBase = new DataBaseAccessObject();

        // Перенаправление запроса на получение списка ID из пользователского слоя в базу данных
        static public List<uint> GetEmployeeID(string Name, string LastName, string MiddleName, string Department)
        {
            return DataBase.GetEmployeeID(Name, LastName, MiddleName, Department);
        }

        // Перенаправление запроса на добавление сотрудника имеющего отчество из пользователского слоя в базу данных
        static public void AddEmployee(string Name, string MiddleName, string LastName, DateTime BirthDate, string Address, string Department, string Description)
        {
            Employee AddedEmployee = new Employee(Name, LastName, MiddleName, BirthDate, Address, Department, Description);
            DataBase.AddEmployee(AddedEmployee);
        }

        // Перенаправление запроса на добавление сотрудника не имеющего отчества списка ID из пользователского слоя в базу данных
        static public void AddEmployee(string Name, string LastName, DateTime BirthDate, string Address, string Department, string Description)
        {
            Employee AddedEmployee = new Employee(Name, LastName, BirthDate, Address, Department, Description);
            DataBase.AddEmployee(AddedEmployee);
        }

        // Перенаправление запроса на получение данных сотрудника по ID из пользователского слоя в базу данных
        static public Employee GetEmployee(uint ID)
        {
            return DataBase.GetEmployee(ID);
        }

        // Перенаправление запроса на изменение данных сотрудника по ID из пользователского слоя в базу данных
        static public void ChangeEmployeeData(Employee ChangedEmployee)
        {
            DataBase.ChangeEmployeeData(ChangedEmployee);
        }

        // Перенаправление запроса на удаление сотрудника по ID из пользователского слоя в базу данных
        static public void DeleteEmployee(uint ID)
        {
            DataBase.DeleteEmployee(ID);
        }

        // Перенаправление запроса на получение данных всех сотрудников по ID из пользователского слоя в базу данных
        static public List<Employee> GetAllData()
        {
            return DataBase.GetAllData();
        }
    }
}
