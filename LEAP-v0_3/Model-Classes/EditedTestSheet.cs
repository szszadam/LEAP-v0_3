using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    /*eighth comment section*/
    class EditedTestSheet
    {
        int _SQL_ID;
        string _subject;
        string _topic;
        int _availableTime;
        int _grade;
        int _totalPointsAvailable;
        bool _lockedTestSheet;
        string[][] _essayKeywordTable;
        bool[][] _multipleChoiceTruthTable;
        DateTime _creationDate;
        List<Task> _editorTaskList = new List<Task>();
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
        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }
        public int AvailableTime
        {
            get { return _availableTime; }
            set { _availableTime = value; }
        }
        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        public int TotalPointsAvailable
        {
            get { return _totalPointsAvailable; }
            set { _totalPointsAvailable = value; }
        }
        public bool LockedTestSheet
        {
            get { return _lockedTestSheet; }
            set { _lockedTestSheet = value; }
        }
        public string[][] EssayKeywordTable
        {
            get { return _essayKeywordTable; }
            set { _essayKeywordTable = value; }
        }
        public bool[][] MultipleChoiceTruthTable
        {
            get { return _multipleChoiceTruthTable; }
            set { _multipleChoiceTruthTable = value; }
        }
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }
        public List<Task> EditorTaskList
        {
            get { return _editorTaskList; }
            set { _editorTaskList = value; }
        }
        public void FillEditorTaskList(string __editorTasks)
        {
            string[] editorTasksStringArray = __editorTasks.Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < editorTasksStringArray.Length; i++)
            {
                if (DB_Connection.MultipleChoiceTaskList.FirstOrDefault(x => x.SQL_ID.Equals(Convert.ToInt32(editorTasksStringArray[i]))) is MultipleChoiceTask)
                {
                    EditorTaskList.Add(DB_Connection.MultipleChoiceTaskList.First(x => x.SQL_ID.Equals(Convert.ToInt32(editorTasksStringArray[i]))));
                }
                else if (DB_Connection.EssayTaskList.FirstOrDefault(x => x.SQL_ID.Equals(Convert.ToInt32(editorTasksStringArray[i]))) is EssayTask)
                {
                    EditorTaskList.Add(DB_Connection.EssayTaskList.First(x => x.SQL_ID.Equals(Convert.ToInt32(editorTasksStringArray[i]))));
                }
            }
        }
        public static void FillMultipleChoiceTruthTable(List<Task> __editorTaskList, out bool[][] __multipleChoiceTruthTable)
        {
            int numberOfMultipleChoiceTasks = __editorTaskList.Where(x => x is MultipleChoiceTask).Count();
            if (numberOfMultipleChoiceTasks != 0)
            {
                __multipleChoiceTruthTable = new bool[numberOfMultipleChoiceTasks][];
                int j = 0;
                for (int i = 0; i < __editorTaskList.Count; i++)
                {
                    if (__editorTaskList[i] is MultipleChoiceTask)
                    {
                        MultipleChoiceTask currentTask = (__editorTaskList[i] as MultipleChoiceTask);
                        int currentNumberOfAnswerOptions = currentTask.AnswerOptionsList.Count();
                        __multipleChoiceTruthTable[j] = new bool[currentNumberOfAnswerOptions];
                        for (int k = 0; k < __multipleChoiceTruthTable[j].Length; k++)
                        {
                            __multipleChoiceTruthTable[j][k] = currentTask.AnswerOptionsList[k]._isThisAnswerCorrect;
                        }
                        j++;
                    }
                }
            }
            else { __multipleChoiceTruthTable = new bool[0][]; }
        }
        public static void FillEssayKeywordTable(List<Task> __editorTaskList,out string[][] __essayKeywordTable)
        {
            int numberOfEssayTasks = __editorTaskList.Where(x => x is EssayTask).Count();
            if (numberOfEssayTasks != 0)
            {
                __essayKeywordTable = new string[numberOfEssayTasks][];
                int j = 0;
                for (int i = 0; i < __editorTaskList.Count; i++)
                {
                    if (__editorTaskList[i] is EssayTask)
                    {
                        EssayTask currentTask = (__editorTaskList[i] as EssayTask);
                        int currentNumberOfEssayKeywords = currentTask.KeywordsList.Count();
                        __essayKeywordTable[j] = new string[currentNumberOfEssayKeywords];
                        for (int k = 0; k < __essayKeywordTable[j].Length; k++)
                        {
                            __essayKeywordTable[j][k] = currentTask.KeywordsList[k];
                        }
                        j++;
                    }
                }
            }
            else { __essayKeywordTable = new string[0][]; }
        }
        public static void EditorTasksConvertFromListToString(List<Task> __editorTaskList, out string __editorTasksString)
        {
            __editorTasksString = "";
            for (int i = 0; i < __editorTaskList.Count; i++)
            {
                __editorTasksString += Convert.ToString(__editorTaskList[i].SQL_ID);
                __editorTasksString += "▼";
            }
        }
        public EditedTestSheet(int __sql_id, string __subject, string __topic, int __availableTime, int __grade, int __totalPointsAvailable, bool __lockedTestSheet, DateTime __creationDate, string __editorTasks)
        {
            this.SQL_ID = __sql_id;
            this.Subject = __subject;
            this.Topic = __topic;
            this.AvailableTime = __availableTime;
            this.Grade = __grade;
            this.TotalPointsAvailable = __totalPointsAvailable;
            this.LockedTestSheet = __lockedTestSheet;
            this.CreationDate = __creationDate;

            FillEditorTaskList(__editorTasks);
            FillMultipleChoiceTruthTable(_editorTaskList, out _multipleChoiceTruthTable);
            FillEssayKeywordTable(_editorTaskList, out _essayKeywordTable);
        }
    }
}
