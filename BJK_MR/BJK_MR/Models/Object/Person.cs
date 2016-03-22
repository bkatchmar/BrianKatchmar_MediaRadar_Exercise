using System;

namespace BJK_MR.Models.Objects
{
    public class Person
    {
        #region Private Variables
        private string m_firstName;
        private string m_lastName;
        #endregion

        #region Constructor
        public Person(string firstName = "Brian", string lastName = "Katchmar")
        {
            this.m_firstName = firstName;
            this.m_lastName = lastName;
        }
        #endregion

        #region Public Variables
        public string FirstName
        {
            get { return this.m_firstName; }
            set { this.m_firstName = value; }
        }
        public string LastName
        {
            get { return this.m_lastName; }
            set { this.m_lastName = value; }
        }
        #endregion

        #region Public Methods
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        #endregion
    }
}