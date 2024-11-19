﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp;


public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public string Address { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string DateOfAdmission { get; set; }


    public override string ToString()
    {
        return Id.ToString();
    }
}
