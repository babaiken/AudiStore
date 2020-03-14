using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AudiStore.DAL.Models
{
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}