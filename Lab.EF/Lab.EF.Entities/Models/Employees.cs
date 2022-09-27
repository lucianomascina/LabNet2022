namespace Lab.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
            Territories = new HashSet<Territories>();
        }

        public Employees(string firstName, string lastName, string title,DateTime birthDate,
                        DateTime hireDate,string address,string city,string homePhone)
        {
            FirstName = firstName;            
            LastName = lastName;
            Title = title;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            HomePhone = homePhone;
        }

        public Employees(int id,string firstName, string lastName, string title, DateTime birthDate,
                        DateTime hireDate, string address, string city,string homePhone)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            HomePhone = homePhone;
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "debe ingresar un apellido de hasta 20 letras")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "debe ingresar un nombre de hasta 10 letras")]
        [StringLength(10)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(25)]
        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string HomePhone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? ReportsTo { get; set; }

        [StringLength(255)]
        public string PhotoPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees1 { get; set; }

        public virtual Employees Employees2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territories> Territories { get; set; }
       
    }
}
