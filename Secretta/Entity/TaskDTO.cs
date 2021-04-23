using System;
using System.ComponentModel.DataAnnotations;

namespace Secretta.Entity
{
    public class TaskDTO
    {
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public string Cliente { get; set; }
        public DateTime Horario { get; set; }
    }
}
