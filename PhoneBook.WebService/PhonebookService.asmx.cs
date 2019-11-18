using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PhoneBook.DataAccess;

namespace PhoneBook.WebService
{
    /// <summary>
    /// Summary description for PhonebookService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class PhonebookService : System.Web.Services.WebService
    {

        private readonly PhonebookModel _model;

        public PhonebookService()
        {
            _model = new PhonebookModel();
        }

        [WebMethod]
        public string Get(string phone)
        {
            var item = _model.Phonebooks.FirstOrDefault(p => p.Phone == phone);

            return item != null ? item.Name + ": " + item.Phone : "Not found!";
        }
    }
}
