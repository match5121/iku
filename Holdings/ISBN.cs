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
        private int? _eanPrefix = null;
        private int _registrationGroup;
        private int _registrant;
        private int _publication;
        private int _checkdegit;

        /// <summary>
        /// ISBN-10 (旧規格)
        /// </summary>
        /// <param name="registrationGroup">グループ記号</param>
        /// <param name="registrant">出版者記号</param>
        /// <param name="publication">書名記号</param>
        /// <param name="checkdegit">チェック数字</param>
        public ISBN(int registrationGroup, int registrant, int publication, int checkdegit)
        {
            _registrationGroup = registrationGroup;
            _registrant        = registrant;
            _publication       = publication;
            _checkdegit        = checkdegit;
            //TODO checkdegitの検証
        }

        /// <summary>
        /// ISBN-13 (現行規格)
        /// </summary>
        /// <param name="eanPrefix">EANコード接頭辞</param>
        /// <param name="registrationGroup">グループ記号</param>
        /// <param name="registrant">出版者記号</param>
        /// <param name="publication">書名記号</param>
        /// <param name="checkdegit">チェック数字</param>
        public ISBN(int eanPrefix, int registrationGroup, int registrant, int publication, int checkdegit)
        {
            _eanPrefix = eanPrefix;
            _registrationGroup = registrationGroup;
            _registrant = registrant;
            _publication = publication;
            _checkdegit = checkdegit;
            //TODO checkdegitの検証
        }

        public override string ToString()
        {
            return "" + _eanPrefix + _registrationGroup + _registrant + _publication + _checkdegit;
        }
    }
}
