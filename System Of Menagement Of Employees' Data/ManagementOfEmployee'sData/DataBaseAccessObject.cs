// Данный класс содержит подключение к базе данных созданной с помощью СУБД Devart.SQLite и запросы для даной БД


using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using Devart.Data;
using System.Data.Common;
using Devart.Data.SQLite;
using System.Configuration;


namespace ManagementOfEmployee_sData
{
    class DataBaseAccessObject
    {
        // Соединение с базой данных
        SQLiteConnection Connection = new SQLiteConnection("Data Source = Employee\'sDataBace.db3");
        SQLiteCommand Command;
        SQLiteDataReader Reader;
        // Создание экземпляра класса
        public DataBaseAccessObject()
        {
            // Подключение к БД или её создание, если нужной БД не существует
            if (!File.Exists("Employee\'sDataBace.db3"))
            {
                SQLiteConnection.CreateFile("Employee\'sDataBace.db3");
            }
            Connection.Open();
            // Создание таблицы для хранения данных если такой не существует
            using (Command = new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS [Employees] (
                    [ID] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [LastName] TEXT NOT NULL,
                    [Name] TEXT NOT NULL,
                    [MiddleName] TEXT,
                    [BirthDate] DATE NOT NULL,
                    [Address] TEXT NOT NULL,
                    [Department] TEXT NOT NULL,
                    [DescriptionOfYourself] TEXT NOT NULL
                    );", Connection))
            {
                Command.CommandType = CommandType.Text;
                Command.ExecuteNonQuery();
            }
        }

        // Объявление функции находящей сотрудников по ФИО и Отделу и возвращающая список их ID
        public List<uint> GetEmployeeID(string Name, string LastName, string MiddleName, string Department)
        {
            // Отправка запроса в БД и обработка полученого отклика
            Command = new SQLiteCommand("SELECT [ID] FROM [Employees] WHERE [Name] = @Name AND [LastName] = @LastName AND [MiddleName] = @MiddleName AND [Department] = @Department", Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@MiddleName", MiddleName);
            Command.Parameters.AddWithValue("@Department", Department);
            Reader = Command.ExecuteReader();
            var ListOfID = new List<uint>();
            int ID;
            // Сохранение полученных ID
            while (Reader.Read())
            {
                ID =Reader.GetInt32("ID");
                ListOfID.Add((uint)ID);
            }
            return ListOfID;
        }

        // Объявление функции добавляющей струдника в БД
        public void AddEmployee(Employee AddedEmployee)
        {
            // Добавление сотрудника имеющего отчество
            if (AddedEmployee.MiddleName != "")
            {
                // Отправка запроса в БД
                Command = new SQLiteCommand("INSERT INTO Employees (Name, LastName, MiddleName, BirthDate, Address, Department, DescriptionOfYourself) VALUES (@Name, @LastName, @MiddleName, @BirthDate, @Address, @Department, @DescriptionOfYourself)", Connection);
                Command.Parameters.AddWithValue("@Name", AddedEmployee.Name);
                Command.Parameters.AddWithValue("@LastName", AddedEmployee.LastName);
                Command.Parameters.AddWithValue("@MiddleName", AddedEmployee.MiddleName);
                Command.Parameters.AddWithValue("@BirthDate", AddedEmployee.BirthDate);
                Command.Parameters.AddWithValue("@Address", AddedEmployee.Address);
                Command.Parameters.AddWithValue("@Department", AddedEmployee.Department);
                Command.Parameters.AddWithValue("@DescriptionOfYourself", AddedEmployee.DescriptionOfYourself);
                Command.ExecuteNonQuery();
            }
            // Добавление сотрудника не имеющего отчества
            else
            {
                // Отправка запроса в БД
                Command = new SQLiteCommand("INSERT INTO Employees (ID, Name, LastName, MiddleName, BirthDate, Address, Department, DescriptionOfYourself) VALUES @Name, @LastName, @MiddleName, @BirthDate, @Address, @Department, @DescriptionOfYourself)", Connection);
                Command.Parameters.AddWithValue("@Name", AddedEmployee.Name);
                Command.Parameters.AddWithValue("@LastName", AddedEmployee.LastName);
                Command.Parameters.AddWithValue("@MiddleName", "NULL");
                Command.Parameters.AddWithValue("@BirthDate", AddedEmployee.BirthDate);
                Command.Parameters.AddWithValue("@Address", AddedEmployee.Address);
                Command.Parameters.AddWithValue("@Department", AddedEmployee.Department);
                Command.Parameters.AddWithValue("@DescriptionOfYourself", AddedEmployee.DescriptionOfYourself);
                Command.ExecuteNonQuery();
            }
        }
        
        // Объявление функции получающей данные сотрулника по его ID
        public Employee GetEmployee(uint ID)
        {
            // Отправка запроса в БД и обработка полученного отклика
            Command = new SQLiteCommand("SELECT * FROM [Employees] WHERE [ID] = @ID", Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Reader = Command.ExecuteReader();
            Employee ReturnedEmployee = null;
            string Name;
            string LastName;
            string MiddleName;
            DateTime BirthDate;
            string Adress;
            string Department;
            string DescriptionOfYourself;
            // Сохранение полученных данных в возвращаемую переменную
            while (Reader.Read())
            {
                Name = (string)Reader["Name"];
                LastName = (string)Reader["LastName"];
                MiddleName = (string)Reader["MiddleName"];
                BirthDate = (DateTime)Reader["BirthDate"];
                Adress = (string)Reader["Address"];
                Department = (string)Reader["Department"];
                DescriptionOfYourself = (string)Reader["DescriptionOfYourself"];
                if (MiddleName == "NULL")
                {
                    ReturnedEmployee = new Employee(ID, Name, LastName, BirthDate, Adress, Department, DescriptionOfYourself);
                }
                else
                {
                    ReturnedEmployee = new Employee(ID, Name, LastName, MiddleName, BirthDate, Adress, Department, DescriptionOfYourself);
                }
            }
            return ReturnedEmployee;
        }

        // Объявление функции изменяющей данные сотрудника
        public void ChangeEmployeeData(Employee ChangedEmployee)
        {
            // Отправка запроса в БД
            Command = new SQLiteCommand("UPDATE [Employees] SET [Name] = @Name, [LastName] = @LastName, [MiddleName] = @MiddleName, [BirthDate] = @BirthDate, [Address] = @Address, [Department] = @Department, [DescriptionOfYourself] = @DescriptionOfYourself WHERE [ID] = @ID", Connection);
            Command.Parameters.AddWithValue("@ID", ChangedEmployee.ID);
            Command.Parameters.AddWithValue("@Name", ChangedEmployee.Name);
            Command.Parameters.AddWithValue("@LastName", ChangedEmployee.LastName);
            Command.Parameters.AddWithValue("@MiddleName", ChangedEmployee.MiddleName);
            Command.Parameters.AddWithValue("@BirthDate", ChangedEmployee.BirthDate);
            Command.Parameters.AddWithValue("@Address", ChangedEmployee.Address);
            Command.Parameters.AddWithValue("@Department", ChangedEmployee.Department);
            Command.Parameters.AddWithValue("@DescriptionOfYourself", ChangedEmployee.DescriptionOfYourself);
            Reader = Command.ExecuteReader();
        }

        // Объявление функции уаляющей сотрудника
        public void DeleteEmployee(uint ID)
        {
            // Отправка запроса в БД
            Command = new SQLiteCommand("DELETE FROM [Employees] WHERE [ID] = @ID", Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            Reader = Command.ExecuteReader();
        }

        // Объявление функции возвращающей всех сотрудников
        public List <Employee> GetAllData()
        {
            // Отправка запроса в БД
            Command = new SQLiteCommand("SELECT * FROM [Employees]", Connection);
            Reader = Command.ExecuteReader();
            List<Employee> ReturnedEmployees = new List<Employee>();
            Employee ReturnedEmployee;
            int ID;
            string Name;
            string LastName;
            string MiddleName;
            DateTime BirthDate;
            string Adress;
            string Department;
            string DescriptionOfYourself;
            // Сохранение полученных данных в возвращаемую переменную
            while (Reader.Read())
            {
                ID = Reader.GetInt32("ID");
                Name = (string)Reader["Name"];
                LastName = (string)Reader["LastName"];
                MiddleName = (string)Reader["MiddleName"];
                BirthDate = (DateTime)Reader["BirthDate"];
                Adress = (string)Reader["Address"];
                Department = (string)Reader["Department"];
                DescriptionOfYourself = (string)Reader["DescriptionOfYourself"];
                if (MiddleName == "NULL")
                {
                    ReturnedEmployee = new Employee((uint)ID, Name, LastName, BirthDate, Adress, Department, DescriptionOfYourself);
                }
                else
                {
                    ReturnedEmployee = new Employee((uint)ID, Name, LastName, MiddleName, BirthDate, Adress, Department, DescriptionOfYourself);
                }
                ReturnedEmployees.Add(ReturnedEmployee);
            }
            return ReturnedEmployees;
        }
    }
}
