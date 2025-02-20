using less1.validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less1
{
    /// <summary>
    /// описание класса, что он делает и тк, на англ(сайты для перевода: deepl, reverse, lingvo)
    /// рост, вес, др, имя, фамилия
    /// </summary>
    internal class person
    {
        public int Height {  get; private set; }

        public int Weidth { get; private set; }

        public DateTime BirthDay{ get; }

        public string FirstName { get; private set; }

        public string LastName { get; private set;}

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        
        public int Age //переделать
        {
            get
            {
                return(DateTime.Now - BirthDay).Days/365;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Height"></param>
        /// <returns></returns>
        public bool ChangeHeight(int Height)
        {
            bool isValidate = intValidator.Validate(Height);
            if(isValidate)
                this.Height = Height;
            return isValidate;
        }
    }
}
