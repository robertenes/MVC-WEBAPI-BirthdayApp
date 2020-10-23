using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public class DataBase
    {
        private static Dictionary<string, InvitationModel> _list;
        static DataBase()
        {
            _list = new Dictionary<string, InvitationModel>();
            _list.Add("John", new InvitationModel
            {
                Name = "John",
                Mail = "john@gmail.com",
                JoinState = true
            });
            _list.Add("Enes", new InvitationModel
            {
                Name = "Enes",
                Mail = "enes@gmail.com",
                JoinState = true
            });
            _list.Add("Hakan", new InvitationModel
            {
                Name = "Hakan",
                Mail = "hakan@gmail.com",
                JoinState = false
            });

        }
        public static void Add(InvitationModel model)
        {
            string key = model.Name.ToLower();
            if(_list.ContainsKey(key))
            {
                _list[key] = model;
            }
            else
            {
                _list.Add(key, model);
            }
        }
        public static IEnumerable<InvitationModel> list
        {
            get { return _list.Values; }
        }
    }
}