using System.Collections.Generic;
using System.Linq;

namespace StudentDetails
{
    public class GenderDataAccess
    {
        private List<GenderModel> _genderList;
        
        public  GenderDataAccess()
        {
           if(_genderList == null)
            {
                _genderList = new List<GenderModel>
                {
                    new GenderModel{Key ="Male", Value = 0},
                    new GenderModel{Key = "Female", Value = 1}
                };
            }
        }

        /// <summary>
        /// Gets The list of Genders 
        /// </summary>
        /// <returns>It returns gender list</returns>
        public List<GenderModel> GetGenders()
        {
            return _genderList;
        }

        /// <summary>
        /// Return Gender Text Based on Gender ID
        /// </summary>
        /// <param name="genderID">Gender Id</param>
        /// <returns>Return the gender text</returns>
        public string GenderText(int genderID)
        {
            return _genderList.Where(x => x.Value == genderID).Select
                (x => x.Key).FirstOrDefault();
        }
    }
}
