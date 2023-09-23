using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****Task class*****
    //
    //
    //      ***Class description***
    //
    //
    // It is the parent class of the essay task class and multiple-choice task class.
    //
    //
    //      ***Fields***
    //
    //
    // _SQL_ID: int – it is used to store the primary key(ID / sequence number) stored in the
    // SQL database belonging to the task.
    //
    //
    // _subject: string- it is used to store the name of the subject belonging to the assignment.
    //
    //
    // _taskFormulation: string - it is used to store the formulation of
    // the task / question belonging to the task.
    //
    //
    // _taskType: string – it is used to store the type of task (essay or multiple-choice)
    //
    //
    // _pointValue: int- it is used to store the maximum point value available for the task.
    //
    //
    // _lockedTask: bool – it stores whether the task is locked or can still be modified

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
