using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVotingSystem
{

    public class Campaign
    {
        private int _length;
        private string _name;
        private bool _isCurrent;

        public int Length { get => _length; set => _length = value; }
        public string Name { get => _name; set => _name = value; }
        public bool IsCurrent { get => _isCurrent; set => _isCurrent = value; }

        public Campaign(string name, int length, bool isCurrent)
        {
            this._name = name;
            this._length = length;
            this._isCurrent = isCurrent;

        }


    }
}
