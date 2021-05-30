using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ClinicManagement.Core.Models;

namespace ClinicManagement.Core.ViewModel
{
    public class DoctorFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public bool IsAvailable { get; set; }


        [Required]
        public int Specialization { get; set; }

        public IEnumerable<Specialization> Specializations { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }

        public RegisterViewModel RegisterViewModel { get; set; }

    }
}
