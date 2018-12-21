using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_AdventureGame.Models
{
    public class Location
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private int _id;
        private string _name;
        private string _description;
        private bool _isAccessible;
        private int _experiencePoints;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool IsAccessible
        {
            get { return _isAccessible; }
            set { _isAccessible = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Location()
        {

        }

        public Location(int id, string name, bool isAccessible)
        {

        }

        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion
    }
}
