using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act9_1
{
    class SeatingAssignment
    {
        private int row;
        private int seat;
        private string student;
        
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        public string Student
        {
            get { return student; }
            set { student = value; }
        }
        
        //Constructor
        public SeatingAssignment(int row, int seat, string student)
        {
            this.Row = row;
            this.Seat = seat;
            this.Student = student;
        }

    }
}
