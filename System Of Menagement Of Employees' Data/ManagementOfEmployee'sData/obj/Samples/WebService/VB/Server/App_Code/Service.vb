Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Data
Imports System.Configuration
Imports Devart.Data.SQLite

<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
  Inherits System.Web.Services.WebService

  Private dataSet As DataSet = New DataSet
  Private connection As SQLiteConnection
  Private dataAdapter As SQLiteDataAdapter

  <WebMethod()> _
  Public Function FetchData(ByVal query As String) As System.Data.DataSet
    Me.connection = New SQLiteConnection(ConfigurationManager.ConnectionStrings("ProviderService").ConnectionString)
    Me.dataAdapter = New SQLiteDataAdapter("", Me.connection)

    Select Case query
      Case "all employees"
        dataAdapter.SelectCommand.CommandText = "SELECT * FROM emp"
      Case "all departments"
        dataAdapter.SelectCommand.CommandText = "SELECT * FROM dept"
      Case "employees having commission"
        dataAdapter.SelectCommand.CommandText = "SELECT * FROM emp WHERE comm > 0"
      Case "average salary by departments"
        dataAdapter.SelectCommand.CommandText = "SELECT dname AS department, AVG(sal) AS average_salary FROM dept, emp WHERE dept.deptno=emp.deptno GROUP BY dname"
      Case "employees' hire by years"
        dataAdapter.SelectCommand.CommandText = "SELECT strftime('%Y', hiredate) AS year, COUNT(empno) AS quantity FROM emp GROUP BY 1 ORDER BY 1"
      Case "employees' number by departments"
        dataAdapter.SelectCommand.CommandText = "SELECT dname, COUNT(empno) FROM dept LEFT JOIN emp ON dept.deptno = emp.deptno GROUP BY dname"
      Case "employees having no subordinates"
        dataAdapter.SelectCommand.CommandText = "SELECT e1.* FROM emp e1 LEFT JOIN emp e2 ON e1.empno = e2.mgr WHERE e2.mgr IS NULL"
      Case "employees having subordinates and manager"
        dataAdapter.SelectCommand.CommandText = "SELECT * FROM emp WHERE (mgr IS NOT NULL) AND (empno IN (SELECT DISTINCT mgr FROM EMP))"
      Case "employees with minimal salary by departments"
        dataAdapter.SelectCommand.CommandText = "SELECT dname, ename, sal FROM dept, emp WHERE sal = (SELECT MIN(sal) FROM emp WHERE dept.deptno = emp.deptno)"
      Case "seniority-salary trend"
        dataAdapter.SelectCommand.CommandText = "SELECT strftime('%Y', 'now') - strftime('%Y', hiredate) AS seniority, AVG(sal) AS average_salary FROM emp GROUP BY 1 ORDER BY 1"
      Case Else
        Return Nothing
    End Select

    dataAdapter.Fill(dataSet)

    Return dataSet
  End Function

End Class
