﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClient.ViewModels
{
    public class StudentsAcademyVM
    {
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int StdId { get; set; }
        [ForeignKey("ClassName")]
        public int ClassID { get; set; }
        [ForeignKey("Section")]
        public int SectionID { get; set; }
        [ForeignKey("Shift")]
        public int ShiftID { get; set; }
        [ForeignKey("Department")]
        public int DeptID { get; set; }
        [ForeignKey("GroupProgram")]
        public int GrpProgramID { get; set; }
        [ForeignKey("Semester")]
        public int SemesterId { get; set; }
        public int STdYear { get; set; }
        public GroupProgramVM GroupProgram { get; set; }
        public ClassNameVM ClassName { get; set; }
        public SectionVM Section { get; set; }
        public ShiftVM Shift { get; set; }
        public SemesterVM Semester { get; set; }
        public DepartmentVM Department { get; set; }
        public StudentVM Student { get; set; }
    }
}