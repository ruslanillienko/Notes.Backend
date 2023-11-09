using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoLists.Domain
{
    public class ToDoItem
    {
        public Guid UserId { get; set; }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "ItemName is required")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "ItemDescription is required")]
        public string ItemDescription { get; set; }

        [Required(ErrorMessage = "ItemStatus is required")]
        public bool ItemStatus { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? EditDate { get; set; }


    }
}
