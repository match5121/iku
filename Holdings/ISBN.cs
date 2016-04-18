using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holding
{
    /// <summary>
    /// International Standard Book Number
    /// </summary>
    public class ISBN
    {
        private string _eanPrefix = null;
        private string EANPrefix
        {
            get
            {
                return _eanPrefix;
            }
            set
            {
                int.Parse(value);
                _eanPrefix = value;
            }
        }

        private string _registrationGroup;
        private string RegistrationGroup
        {
            get
            {
                return _registrationGroup;
            }
            set
            {
                int.Parse(value);
                _registrationGroup = value;
            }
        }

        private string _registrant;
        private string Registrant
        {
            get
            {
                return _registrant;
            }
            set
            {
                int.Parse(value);
                _registrant = value;
            }
        }

        private string _publication;
        private string Publication
        {
            get
            {
                return _publication;
            }
            set
            {
                int.Parse(value);
                _publication = value;
            }
        }

        private string _checkdegit;
        private string Checkdegit
        {
            get
            {
                return _checkdegit;
            }
            set
            {
                int.Parse(value);
                _checkdegit = value;
            }
        }

        /// <summary>
        /// ISBN-10 (旧規格)
        /// </summary>
        /// <param name="registrationGroup">グループ記号</param>
        /// <param name="registrant">出版者記号</param>
        /// <param name="publication">書名記号</param>
        /// <param name="checkdegit">チェック数字</param>
        public ISBN(string registrationGroup, string registrant, string publication, string checkdegit)
        {
            RegistrationGroup = registrationGroup;
            Registrant        = registrant;
            Publication       = publication;
            Checkdegit        = checkdegit;
        }

        /// <summary>
        /// ISBN-13 (現行規格)
        /// </summary>
        /// <param name="eanPrefix">EANコード接頭辞</param>
        /// <param name="registrationGroup">グループ記号</param>
        /// <param name="registrant">出版者記号</param>
        /// <param name="publication">書名記号</param>
        /// <param name="checkdegit">チェック数字</param>
        public ISBN(string eanPrefix, string registrationGroup, string registrant, string publication, string checkdegit)
        {
            EANPrefix = eanPrefix;
            RegistrationGroup = registrationGroup;
            Registrant = registrant;
            Publication = publication;
            Checkdegit = checkdegit;
        }

        public override string ToString()
        {
            var prefix = EANPrefix != null ? EANPrefix + "-" : null;
            return "ISBN" + prefix + RegistrationGroup + "-" + Registrant + "-" + Publication + "-" + Checkdegit;
        }
    }
}
