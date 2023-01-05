using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    class EssayTask : Task
    {
        List<string> _keywordsList = new List<string>();
        public List<string> KeywordsList
        {
            get { return _keywordsList; }
            set { _keywordsList = value; }
        }
        public EssayTask(int __sql_id, string __subject, string __taskFormulation, string _taskType, int __pointValue, bool __lockedTask, string __keywords)
        {
            this.SQL_ID = __sql_id;
            this.Subject = __subject;
            this.TaskFormulation = __taskFormulation;
            this.TaskType = _taskType;
            this.PointValue = __pointValue;
            this.LockedTask = __lockedTask;
            string[] keywordsArray = __keywords.Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < keywordsArray.Length; i++)
            {
                KeywordsList.Add(keywordsArray[i]);
            }
        }
    }
}
