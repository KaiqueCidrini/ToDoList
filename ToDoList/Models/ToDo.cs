using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Descrição { get; set; }
        public DateTime Vencimento { get; set; }
        public bool Feito { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}