using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)//constructor new yapıldığında çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person )
        {
            /*ttManager pttManager = new PttManager(new ForeignerManager());*/

            //PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");                               
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilmiyor.");
            }

        }
    }
}
