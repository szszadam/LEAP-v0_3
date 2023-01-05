using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    public class Task
    {
        int _SQL_ID;
        string _subject;
        string _taskFormulation;
        string _taskType;
        int _pointValue;
        bool _lockedTask;
        public int SQL_ID
        {
            get { return _SQL_ID; }
            set { _SQL_ID = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public string TaskFormulation
        {
            get { return _taskFormulation; }
            set { _taskFormulation = value; }
        }
        public string TaskType
        {
            get { return _taskType; }
            set { _taskType = value; }
        }
        public int PointValue
        {
            get { return _pointValue; }
            set { _pointValue = value; }
        }
        public bool LockedTask
        {
            get { return _lockedTask; }
            set { _lockedTask = value; }
        }
    }
}
