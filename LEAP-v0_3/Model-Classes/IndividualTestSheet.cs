using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LEAP_v0_3
{
    //      *****IndividualTestSheet class*****
    //  
    //      ***Class description***
    //
    // It is used to store test sheets based on "edited test sheet" sent to users.
    // These individual test sheets are solved and returned by the students.
    //
    //       ***Fields***
    //
    // _SQL_ID_individualTestSheet: int- it is used to store the primary key(ID / sequence number)
    // stored in the SQL database belonging to the test sheets.
    //
    // _SQL_ID_editedTestSheet: int – it is used to store the primary key (ID / sequence number)
    // stored in the SQL database belonging to the edited test sheets on which the individual
    // test sheets are based.
    //
    // _SQL_ID_user: int - it is used to store the primary key(ID / sequence number)
    // stored in the SQL database belonging to the owner(user) of the individual test sheet.
    //
    // _testSheetStartTime: DateTime – It is used to store the start time of the test sheet.
    //
    // _testSheetSubmitTime: DateTime - It is used to store the submission time of the test sheet.
    //
    // _sentOutTestSheet: bool – has the test sheet already been sent out by a teacher or an administrator?
    //
    // _submittedTestSheet: bool – was the test sheet submitted by the user who solved it?
    //
    // _checkedTestSheet: bool- was the test sheet checked/evaluated by a teacher or an administrator?
    //
    // _answerMarkingsTable: bool[][] – The user's answers to the multiple-choice questions.
    // The first dimension itself represents the sequence of multiple-choice tasks in the task list
    // of the test sheet (and also on the display interface). The second dimension represents
    // the marking of the answer options for the given multiple-choice task and stores whether
    // the user considers the given answer option to be true or false.
    //
    // _pointsEarnedArray: int[] – It stores the points achieved by the user for the tasks
    // in the task list, according to the order of the task list.
    //
    // _individualTaskList: List<Feladat> - The list of the "Task" type objects, the building blocks
    // of the individual test sheet,.
    //
    // _essayTaskAnswers: List<string> - It stores the user's answers to the essay type tasks,
    // according to the order of the task list.
    //
    //      ***Methods***
    //
    // SetupAnswerMarkingsTableDimensions() – Used to set the value of the dimensions itself
    // of the _answerMarkingsTable field.Typically, the edited test sheet
    // - that serves as the basis for the individual test sheet - passes to it the truth table for
    // multiple-choice questions as a parameter, which must match the _answerMarkingsTable
    // in its type and the dimensions of the jagged array.In this way, it is possible to create an
    // initial jagged array be created(by default only filled with "false" values) that has
    // the appropriate values of its dimensions.
    //
    // AutomaticEvaluationOfMultipleChoiceTask() – When the individual test sheet is submitted,
    // it is an automatic running method that immediately evaluates the answers to
    // the multiple-choice tasks.For a multiple-choice task, user can get a maximum of
    // as many points as many true answers are among the answer options. In the case of
    // a correct answer, +1 point is given, but in the case of an incorrect answer, -1 point is
    // deducted.But in the worst case, we can get zero points for a multiple-choice task
    // (the final score for the task cannot be negative).
    //
    // FillIndividualTaskList() – Filling up the list of tasks, in which the reference of
    // the tasks of edited test sheet is stored.
    //
    // FillPointsEarnedArray() – reading the point values from the SQL database earned for
    // the tasks of the individual test sheet.These earned point values are stored in one field
    // in the database, so that the point values are separated from each other with the help of
    // the '▼' „unit separator” character.The method performs splitting along this character and
    // places the earned point values in the corresponding integer array.
    //
    // FillAnswerMarkingsTableWithCustomValues() - reading the answer data from the SQL database
    // for the multiple-choice tasks of the individual test sheet.These answer markings are stored
    // in one field in the database, so that the task units are separated from each other by
    // the '▲'  “record separator” character, and the answer markings within the task subdivisions
    // are separated from each other by the '▼'  “unit separator” character.Along these characters,
    // the method performs the appropriate separation and places the resulting answer marks
    // in the appropriate logical, jagged array.
    //
    // FillEssayAnswersList() - reading the answer data from the SQL database for the essay tasks
    // of the individual test sheet. These multi-sentence answers are stored in one field in
    // the database, so that the answers to the tasks are separated by '▼' “unit separator” character.
    // Based on this character, the method performs the appropriate separation and places the resulting
    // answer marks in the corresponding text list.

    class IndividualTestSheet
    {
        int _SQL_ID_individualTestSheet;
        int _SQL_ID_editedTestSheet;
        int _SQL_ID_user;
        DateTime _testSheetStartTime;
        DateTime _testSheetSubmitTime;
        bool _sentOutTestSheet;
        bool _submittedTestSheet;
        bool _checkedTestSheet;
        bool[][] _keywordFulfillmentTable;
        bool[][] _answerMarkingsTable;
        int[] _pointsEarnedArray;
        List<Task> _individualTaskList;
        List<string> _essayTaskAnswers;

        public int SQL_ID_individualTestSheet
        {
            get { return _SQL_ID_individualTestSheet; }
            set { _SQL_ID_individualTestSheet = value; }
        }
        public int SQL_ID_editedTestSheet
        {
            get { return _SQL_ID_editedTestSheet; }
            set { _SQL_ID_editedTestSheet = value; }
        }
        public int SQL_ID_user
        {
            get { return _SQL_ID_user; }
            set { _SQL_ID_user = value; }
        }
        public int[] PointsEarnedArray
        {
            get { return _pointsEarnedArray; }
            set { _pointsEarnedArray = value; }
        }
        public DateTime TestSheetStartTime
        {
            get { return _testSheetStartTime; }
            set { _testSheetStartTime = value; }
        }
        public DateTime TestSheetSubmitTime
        {
            get { return _testSheetSubmitTime; }
            set { _testSheetSubmitTime = value; }
        }
        public bool SentOutTestSheet
        {
            get { return _sentOutTestSheet; }
            set { _sentOutTestSheet = value; }
        }
        public bool SubmittedTestSheet
        {
            get { return _submittedTestSheet; }
            set { _submittedTestSheet = value; }
        }
        public bool CheckedTestSheet
        {
            get { return _checkedTestSheet; }
            set { _checkedTestSheet = value; }
        }
        public bool[][] KeywordFulfillmentTable
        {
            get { return _keywordFulfillmentTable; }
            set { _keywordFulfillmentTable = value; }
        }
        public bool[][] AnswerMarkingsTable
        {
            get { return _answerMarkingsTable; }
            set { _answerMarkingsTable = value; }
        }
        public List<Task> IndividualTaskList
        {
            get { return _individualTaskList; }
            set { _individualTaskList = value; }
        }
        public List<string> EssayTaskAnswers
        {
            get { return _essayTaskAnswers; }
            set { _essayTaskAnswers = value; }
        }
        public static void SetupKeywordFulfillmentTableDimensions(string[][] __keywordTable, out bool[][] __keywordFulfillmentTable)
        {
            int arrayDimenson_1 = __keywordTable.Length;
            if (arrayDimenson_1 != 0)
            {
                __keywordFulfillmentTable = new bool[arrayDimenson_1][];
                for (int i = 0; i < __keywordTable.Length; i++)
                {
                    int arrayDimenson_2 = __keywordTable[i].Length;
                    __keywordFulfillmentTable[i] = new bool[arrayDimenson_2];
                }
            }
            else { __keywordFulfillmentTable = new bool[0][]; }
        }
        public static void SetupAnswerMarkingsTableDimensions(bool[][] __truthTable,out bool[][] __answerMarkingsTable)
        {
            int arrayDimenson_1 = __truthTable.Length;
            if (arrayDimenson_1 != 0)
            {
                __answerMarkingsTable = new bool[arrayDimenson_1][];
                for (int i = 0; i < __truthTable.Length; i++)
                {
                    int arrayDimenson_2 = __truthTable[i].Length;
                    __answerMarkingsTable[i] = new bool[arrayDimenson_2];
                }
            }
            else { __answerMarkingsTable = new bool[0][]; }
        }
        public static int[] AutomaticEvaluationOfMultipleChoiceTask(bool[][] __truthTable, bool[][] __answerMarkingsTable, List<Task> __individualTaskList, int[] __pointsEarnedArray)
        {
            int j = 0;
            int numberOfCorrectAnswersByExaminee;
            for (int i = 0; i < __individualTaskList.Count; i++)
            {
                numberOfCorrectAnswersByExaminee = 0;
                if (__individualTaskList[i] is MultipleChoiceTask)
                {
                    for (int k = 0; k < __answerMarkingsTable[j].Length; k++)
                    {
                        if ((__answerMarkingsTable[j][k] == true) && (__truthTable[j][k] == true)) numberOfCorrectAnswersByExaminee++;
                        else if ((__answerMarkingsTable[j][k] == true) && (__truthTable[j][k] == false)) numberOfCorrectAnswersByExaminee--;
                    }
                    j++;
                    if (numberOfCorrectAnswersByExaminee < 0) numberOfCorrectAnswersByExaminee = 0;
                    __pointsEarnedArray[i] = numberOfCorrectAnswersByExaminee;
                }
            }
            return __pointsEarnedArray;
        }
        public static void FillIndividualTaskList(int __SQL_ID_editedTestSheet, out List<Task> __individualTaskList)
        {
            __individualTaskList = DB_Connection.EditedTestSheetList.Where(x => x.SQL_ID.Equals(__SQL_ID_editedTestSheet)).SelectMany(y => y.EditorTaskList).ToList();
        }
        public static void FillPointsEarnedArray(string __pointsEarnedString, out int[] __pointsEarnedArray)
        {
            string[] __pointsEarnedStringArray_Auxiliary = __pointsEarnedString.Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
            __pointsEarnedArray = new int[__pointsEarnedStringArray_Auxiliary.Length];
            for (int i = 0; i < __pointsEarnedStringArray_Auxiliary.Length; i++)
            {
                __pointsEarnedArray[i] = Convert.ToInt32(__pointsEarnedStringArray_Auxiliary[i]);
            }
        }
        public static bool[][] FillAnswerMarkingsTableWithCustomValues(string __answerMarkingsTableCustomValuesString, bool[][] __answerMarkingsTable)
        {
            string[] answerMarkingsTableRows = __answerMarkingsTableCustomValuesString.Split(new char[] { '▲' }, StringSplitOptions.RemoveEmptyEntries);
            int arrayDimenson_1 = answerMarkingsTableRows.Length;
            if (arrayDimenson_1 != 0)
            {
                __answerMarkingsTable = new bool[arrayDimenson_1][];
                for (int i = 0; i < answerMarkingsTableRows.Length; i++)
                {
                    string[] answerMarkingsTableRecordElements = answerMarkingsTableRows[i].Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
                    int arrayDimenson_2 = answerMarkingsTableRecordElements.Length;
                    __answerMarkingsTable[i] = new bool[arrayDimenson_2];
                    for (int j = 0; j < answerMarkingsTableRecordElements.Length; j++)
                    {
                        __answerMarkingsTable[i][j] = Convert.ToBoolean(answerMarkingsTableRecordElements[j].Trim());
                    }
                }
            }
            else { __answerMarkingsTable = new bool[0][]; }
            return __answerMarkingsTable;
        }
        public static void FillKeywordTableWithIndividualValues(string __keywordTableIndividualValues, out bool[][] __keywordFulfillmentTable)
        {
            string[] keywordFulfillmentTableRow = __keywordTableIndividualValues.Split(new char[] { '▲' }, StringSplitOptions.RemoveEmptyEntries);
            int arrayDimenson_1 = keywordFulfillmentTableRow.Length;
            if (arrayDimenson_1 != 0)
            {
                __keywordFulfillmentTable = new bool[arrayDimenson_1][];
                for (int i = 0; i < keywordFulfillmentTableRow.Length; i++)
                {
                    string[] keywordFulfillmentTableElements = keywordFulfillmentTableRow[i].Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
                    int arrayDimenson_2 = keywordFulfillmentTableElements.Length;
                    __keywordFulfillmentTable[i] = new bool[arrayDimenson_2];
                    for (int j = 0; j < keywordFulfillmentTableElements.Length; j++)
                    {
                        __keywordFulfillmentTable[i][j] = Convert.ToBoolean(keywordFulfillmentTableElements[j].Trim());
                    }
                }
            }
            else { __keywordFulfillmentTable = new bool[0][]; }
        }
        public static void FillEssayAnswersList(string __essayAnswers, out List<string> __essayAnswersList)
        {
            __essayAnswersList = new List<string>();
            string[] essayAnswersArray = __essayAnswers.Split(new char[] { '▼' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < essayAnswersArray.Length; i++)
            {
                __essayAnswersList.Add(essayAnswersArray[i]);
            }
        }
        public IndividualTestSheet(int __SQL_ID_individualTestSheet, int __SQL_ID_editedTestSheet, int __SQL_ID_user, string __pointsEarned, DateTime __testSheetStartTime, DateTime __testSheetSubmitTime, bool __sentOutTestSheet, bool __submittedTestSheet, bool __checkedTestSheet, string __answerMarkingsTableCustomValuesString, string __essayAnswers, string __keywordTableIndividualValues)
        {
            this.SQL_ID_individualTestSheet = __SQL_ID_individualTestSheet;
            this.SQL_ID_editedTestSheet = __SQL_ID_editedTestSheet;
            this.SQL_ID_user = __SQL_ID_user;
            this.TestSheetStartTime = __testSheetStartTime;
            this.TestSheetSubmitTime = __testSheetSubmitTime;
            this.SentOutTestSheet = __sentOutTestSheet;
            this.SubmittedTestSheet = __submittedTestSheet;
            this.CheckedTestSheet = __checkedTestSheet;
            FillIndividualTaskList(__SQL_ID_editedTestSheet, out _individualTaskList);
            FillPointsEarnedArray(__pointsEarned, out _pointsEarnedArray);
            _answerMarkingsTable = FillAnswerMarkingsTableWithCustomValues(__answerMarkingsTableCustomValuesString,_answerMarkingsTable);
            FillKeywordTableWithIndividualValues(__keywordTableIndividualValues, out _keywordFulfillmentTable);
            FillEssayAnswersList(__essayAnswers, out _essayTaskAnswers);
        }
    }
}
