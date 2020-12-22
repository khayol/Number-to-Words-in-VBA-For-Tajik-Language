using Microsoft.JSInterop;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Woorj.Data;
using Woorj.Data.IndOrg;

namespace Woorj.CtrServerSide.IndOrg
{
    public class ContactController
    {
        private readonly ApplicationDbContext _db;

        public ContactController(ApplicationDbContext db)
        {
            _db=db;
        }
        
        // Get all Contact
        public List<Contact> GetContact(){
          var list_Contact=_db.Contact.ToList();
          return list_Contact;
        }

        // Get Contact by ID
        public Contact GetContactById(int id){
          Contact Contact= _db.Contact.FirstOrDefault(s=> s.Id==id);
          return Contact;
        
        }
        public List<Contact> GetContactById2(int pId){
          // Contact Contact= _db.Contact.FirstOrDefault(s=> s.Id==id);
          // return Contact;

           List<Contact> list_Contact;

            if (pId==0 || string.IsNullOrEmpty(pId.ToString())){
             list_Contact=_db.Contact.ToList();
            }else
            {                
             list_Contact=_db.Contact.Where(s=>s.Id==pId).ToList();
            }
          return list_Contact;
        
        }
        // Get Contact by ID
         public List<Contact> GetContactByIndividualId(int pIndividualId){

              // var list_Contact=_db.Contact.Where(s=>s.IndividualId==pIndividualId) .ToList();
             List<Contact> list_Contact;
              if (pIndividualId==0 || string.IsNullOrEmpty(pIndividualId.ToString())){
             list_Contact=_db.Contact.ToList();
            }else
            {                
             list_Contact=_db.Contact.Where(s=>s.IndividualId==pIndividualId) .ToList();
            }
          return list_Contact;
        }
        public string GetContactCodeById(int id){
          string code= _db.Contact.FirstOrDefault(s=> s.Id==id).Code.ToString();
          return code;
        }

        // Insert Contact
        public string Create(Contact obj_Contact){
              _db.Contact.Add(obj_Contact);
              _db.SaveChanges();
              return "Save Successfully";

        }

        // Edit Contact
        public string UpdateContact(Contact obj_Contact){
              _db.Contact.Update(obj_Contact);
              _db.SaveChanges();
              return "Edited Successfully";

        }

          // Delete Contact
        public string DeleteContact(Contact obj_Contact){
              _db.Remove(obj_Contact); // _db.Contact.Remove(obj_Contact); 
              _db.SaveChanges();
              return "Delete Successfully";

        }

                // Generate Excel
        public void GenerateExcel(IJSRuntime JSRuntime,int pIndividualId)
        {
            byte[] fileContetnts;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string infoName = "Contact";
            IList<Contact> ContactList = _db.Contact.Where(s=>s.IndividualId==pIndividualId).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(infoName);
                int totalRows = ContactList.Count();

                #region Header_Row
                worksheet.Cells[1, 1].Value = "Id";
                worksheet.Cells[1, 2].Value = "Code";
                worksheet.Cells[1, 3].Value = "Name";
                #endregion Header_Row

                #region body_Row
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = ContactList[i].Id;
                    worksheet.Cells[row, 2].Value = ContactList[i].Code;
                    worksheet.Cells[row, 3].Value = ContactList[i].Name;
                  i++;
                }
                #endregion body_Row

                fileContetnts = package.GetAsByteArray();
            }

            JSRuntime.InvokeAsync<Contact>(
                "saveAsFile",
                infoName+".xlsx",
                Convert.ToBase64String(fileContetnts));

        }

         // Add here the Individual Id should be equal the selected one
        // Get Contact by ByFiled
        public List<Contact> GetContactByFiled(string searchTxt, int pIndividualId){
        var list_Contact = _db.Contact
                              .Where(i=>
                                      (i.Code.ToString().Contains(searchTxt)
                                      || i.Name.Contains(searchTxt)) && 
                                      i.IndividualId==pIndividualId                                      
                                  ).ToList();
        return list_Contact;
       }



    }
}