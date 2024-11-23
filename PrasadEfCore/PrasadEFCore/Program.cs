using PrasadEFCore;

using (var db = new SchoolContext())
{
    db.Database.EnsureCreated();

    // EF Core CURD Operations

    #region  1. Create / Insert
    var student = new Student { Name = "Prasad",  Age= 10, City = "Bangalore"};
    db.Students.Add(student);
    db.SaveChanges();
    // Note: Student Record is created in DB 
    #endregion 


    #region 2. Update/Edit
    student.Name = "Rama";
    student.City = "pondy";
    db.SaveChanges();
    // Note: Student name changed to Rama and City changed to pondy in DB also
    #endregion


    #region 3. Read/Get
    var dbStudent = db.Students.FirstOrDefault(s => s.Name == "Rama");
    // Note: Will get Rama record;
    #endregion 


    #region 4. Delete/ Remove
    db.Students.Remove(dbStudent);
    // Note: Rama record will be deleted;
    #endregion 
}