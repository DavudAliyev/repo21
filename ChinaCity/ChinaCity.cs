using System;


namespace ChinaCity
{
    public class ChinaCity
    {
        public ChinaCity(int chinapopulation)
        {
            if (chinapopulation > 100)
            {
                ChinaPopulation = chinapopulation;
            }
        }
        public readonly int ChinaPopulation = 100;

        public override int Population
        {
            get => _population;
            set
            {
                if (value >= 100000)
                {
                    _population = value;
                }
            }
        }

    }
}
