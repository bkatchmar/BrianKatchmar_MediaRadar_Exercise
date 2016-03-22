using System;
using System.Collections.Generic;
using System.Linq;
using BJK_MR.MediaRadar;

namespace BJK_MR.Models.Containers
{
    public enum ExerciseNumber
    {
        EXERCISE_1 = 0,
        EXERCISE_2 = 1,
        EXERCISE_3 = 2,
        EXERCISE_4 = 3
    }

    public class AdServiceContainer
    {
        #region Private Variables
        private DateTime bjk_fromDate;
        private DateTime bjk_toDate;
        private List<Ad> bjk_ads;
        private AdDataServiceClient bjk_client;
        private ExerciseNumber bjk_exercise_number;
        #endregion

        #region Contructor(s)
        public AdServiceContainer()
        {
            this.bjk_fromDate = new DateTime(2011, 1, 1, 0, 0, 0);
            this.bjk_toDate = new DateTime(2011, 4, 1, 23, 59, 59);
            this.bjk_exercise_number = ExerciseNumber.EXERCISE_1;

            bjk_client = new AdDataServiceClient();
            bjk_ads = bjk_client.GetAdDataByDateRange(this.bjk_fromDate, this.bjk_toDate).ToList();
            bjk_client.Close();
        }
        #endregion
        
        #region Public Variables
        public List<Ad> Ads
        {
            get { return this.bjk_ads; }
            set { this.bjk_ads = value; }
        }
        public ExerciseNumber ExerciseNumber
        {
            get { return this.bjk_exercise_number; }
            set { this.bjk_exercise_number = value; }
        }
        #endregion
    }
}