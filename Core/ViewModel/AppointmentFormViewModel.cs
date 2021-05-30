using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ClinicManagement.Core.Models;

namespace ClinicManagement.Core.ViewModel
{
    public class AppointmentFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [ValidDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }


        [Required]
        public string Detail { get; set; }

        [Required]
        public bool Status { get; set; }


        [Required]
        public int Patient { get; set; }
        public IEnumerable<Patient> Patients { get; set; }

        [Required]
        public int Doctor { get; set; }

        public IEnumerable<Doctor> Doctors { get; set; }
        public string Heading { get; set; }

        public IEnumerable<Appointment> Appointments { get; set; }


        public DateTime GetStartDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}