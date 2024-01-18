using System;

namespace City
{
    public class City
    {
        private string _name;
        protected int _population;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public virtual int Population
        {
            get => _population;
            set
            {
                if (value >= 0) _population = value;
            }
        }

        private bool CheckName(string name)
        {
            if (String.IsNullOrWhiteSpace(name)) return false;

            if (name.Length < 3 || name.Length > 20) return false;

            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLetter(name[i]))
                    return false;
            }
            return true;
        }
    }
}
