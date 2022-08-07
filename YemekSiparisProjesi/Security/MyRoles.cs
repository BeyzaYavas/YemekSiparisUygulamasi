using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using YemekSiparisProjesi.Models;

namespace YemekSiparisProjesi.Security
{
    public class MyRoles : RoleProvider
    {
        YemekSiparisEntities y= new YemekSiparisEntities();
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            var roles = y.User_Roles.FirstOrDefault(x => x.MailAdress == username);
            return new string[] { roles.KullaniciTipiAd };



            //var kullaniciRol = (from kullanici in y.Kullanici
            //                    join tipG in y.GirisTip on kullanici.KullaniciNo equals tipG.KullaniciNo
            //                    join rol in y.KullaniciTip on tipG.KullaniciTipNo equals rol.KullaniciTipNo
            //                    where kullanici.MailAdress == username
            //                    select rol.KullaniciTipiAd).ToArray();
            //return kullaniciRol;

            //throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}