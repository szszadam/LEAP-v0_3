using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEAP_v0_3
{

    //      *****Multiple- Choice Task class*****
    //
    //
    //      ***Class description***
    //
    //
    // Descends from the “Task” class. It is used to store multiple-choice tasks.
    //
    //
    //     ***Fields***
    //      (beyond the fields of the "Task" class)
    //
    //
    // _answerOptionsList: List<AnswerOptions> - a collection of answer option structures
    // belonging to the task.
    //
    //
    // AnswerOption: struct – an answer option structure consisting of the text of
    // the answer option and its correctness.
    //
    //
    // _answerOptionText: string – it stores the text formulation of an answer option.
    //
    //
    // _isThisAnswerCorrect: bool – it stores the predefined correctness of an answer option.

    class MultipleChoiceTask : Task
    {
        List<AnswerOptions> _answerOptionsList = new List<AnswerOptions>();
        public struct AnswerOptions
        {
            public string _answerOptionText;
            public bool _isThisAnswerCorrect;
        }
        public List<AnswerOptions> AnswerOptionsList
        {
            get { return _answerOptionsList; }
            set { _answerOptionsList = value; }
        }
        public MultipleChoiceTask(int __sql_id, string __subject, string __taskFormulation, string __taskType, int __pointValue, bool __lockedTask, string __answerOptions)
        {
            this.SQL_ID = __sql_id;
            this.Subject = __subject;
            this.TaskFormulation = __taskFormulation;
            this.TaskType = __taskType;
            this.PointValue = __pointValue;
            this.LockedTask = __lockedTask;
            string[] answerOptionRows = __answerOptions.Split(new char[] { '▲' }, StringSplitOptions.RemoveEmptyEntries);
            string answerOptionAuxiliary;
            bool isThisAnswerCorrectAuxiliary;
            for (int i = 0; i < answerOptionRows.Length; i++)
            {
                answerOptionAuxiliary = answerOptionRows[i].Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries)[0];
                isThisAnswerCorrectAuxiliary = Convert.ToBoolean(answerOptionRows[i].Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                AnswerOptionsList.Add(new AnswerOptions { _answerOptionText = answerOptionAuxiliary,_isThisAnswerCorrect=isThisAnswerCorrectAuxiliary});
            }
        }
    }
}
