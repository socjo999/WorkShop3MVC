using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class PersonModel
    {
        [Required, RangeAttribute(0, 10000000)]
        public int Id { get; set; }

        [MinLength(2)]
        public string FirstName { get; set; }
        [MinLength(2)]
        public string LastName { get; set; }
        [Required, RangeAttribute(0, 10000000)]
        public int Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<PersonModel> GetList { get; set; }

        public PersonModel()
        {
            SourceManager sourceManager = new SourceManager();
            GetList = sourceManager.Get();
        }
        
        



        public PersonModel(List<PersonModel> getList = null)//, List<PersonModel> getByIdList=null, List<PersonModel> updateList = null, List<PersonModel> removeList = null)
        {
            SourceManager sourceManager = new SourceManager();
            getList= sourceManager.Get();
            //GetList = getList;
            //GetByIdList = getByIdList;
            //UpdateList = updateList;
            //RemoveList = removeList;
        }
        //public List<PersonModel> GetList { get; set; }
        //public List<PersonModel> GetByIdList { get; set; }
        //public List<PersonModel> UpdateList { get; set; }
        //public List<PersonModel> RemoveList { get; set; }

    }
}
