using System;

namespace BJK_MR.Models.Objects
{
    public class BrandCoverageGrouping
    {
        #region Private Variables
        private string m_brandName;
        private decimal m_totalCoverage;
        #endregion

        #region Constructor
        public BrandCoverageGrouping()
        {
            this.m_brandName = "";
            this.m_totalCoverage = 0M;
        }
        #endregion

        #region Public Variables
        public string BrandName
        {
            get { return this.m_brandName; }
            set { this.m_brandName = value; }
        }
        public decimal TotalCoverage
        {
            get { return this.m_totalCoverage; }
            set { this.m_totalCoverage = value; }
        }
        #endregion
    }
}