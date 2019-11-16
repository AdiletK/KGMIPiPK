using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGMIPiPK.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Lextures> Lextures { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }

    public class TeacherViewModel
    {
        public IEnumerable<Teachers> Teachers { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }


    public class PageViewModel
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }

        public PageViewModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }


    public class FilterViewModel
    {
        public FilterViewModel(List<Course_Group> groups, int? group, List<Teachers> teachers, int? teacher)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            groups.Insert(0, new Course_Group { Code = 0, Group = "Группа ..." });
            Groups = new SelectList(groups, "Code", "Group", group);
            SelectedGroup = group;


            teachers.Insert(0, new Teachers { Fio = "Преподаватель ...", Nom = 0 });
            Teachers = new SelectList(teachers, "Nom", "Fio", teacher);
            SelectedTeacher = teacher;
        }


        public SelectList Groups { get; private set; } // список компаний
        public int? SelectedGroup { get; private set; }   // выбранная компания
        public SelectList Teachers { get; private set; } // список компаний
        public int? SelectedTeacher { get; private set; }   // выбранная компания
    }
}