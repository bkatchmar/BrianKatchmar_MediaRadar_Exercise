using System.Collections.Generic;
using BJK_MR.Models.Objects;

namespace BJK_MR.Models.Containers
{
    public class PersonContainer
    {
        #region Private Variables
        private List<Person> bjk_people;
        #endregion

        #region Contructor(s)
        public PersonContainer()
        {
            this.bjk_people = new List<Person>();
            this.bjk_people.Add(new Person());
        }
        #endregion

        #region Public Variables
        public IList<Person> AllPeople
        {
            get { return this.bjk_people; }
        }
        #endregion
    }
}