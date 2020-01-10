using System.Collections.Generic;

namespace New.Base
{
    public sealed class Dictionary
    {
        public static Dictionary Instance = new Dictionary();
        public sealed  class DictionaryEntity
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }


        private List<string> Keys { get; set; }
        private Dictionary<string, List<DictionaryEntity>> Values { get; set; }
        public List<DictionaryEntity> this[string key]
        {
            get { return Keys.Contains(key) && Values.ContainsKey(key) ? Values[key] : null; }
            set
            {
                if (!Keys.Contains(key))
                {
                    Keys.Add(key);
                }
                Values[key] = value;
            }
        }

        public Dictionary()
        {
            Keys = new List<string>();
            Values = new Dictionary<string, List<DictionaryEntity>>();
            this[DictionaryName.Priority] = new List<DictionaryEntity>
            {

                new DictionaryEntity
                {
                    Code = "1",
                    Name = "☆"
                },
                new DictionaryEntity
                {
                    Code = "2",
                    Name = "☆☆"
                },
                new DictionaryEntity
                {
                    Code = "3",
                    Name = "☆☆☆"
                },
                new DictionaryEntity
                {
                    Code = "4",
                    Name = "☆☆☆☆"
                },
                new DictionaryEntity
                {
                    Code = "5",
                    Name = "☆☆☆☆☆"
                }
            };
            this[DictionaryName.DateType] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "CreateDate"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "PendingDate"
                }
            };
            this[DictionaryName.CaseType] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "Visit"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "Tech_Support"
                },
                new DictionaryEntity
                {
                    Code = "2",
                    Name = "Complain"
                },
                new DictionaryEntity
                {
                    Code = "3",
                    Name = "Repair"
                },
                new DictionaryEntity
                {
                    Code = "4",
                    Name = "Lead"
                }
            };
            this[DictionaryName.CaseStatus] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "Initial"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "Processing"
                },
                new DictionaryEntity
                {
                    Code = "2",
                    Name = "Pending"
                },
                new DictionaryEntity
                {
                    Code = "3",
                    Name = "Complete"
                }
            };
            this[DictionaryName.TaskType] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "Initial"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "Processing"
                },
                new DictionaryEntity
                {
                    Code = "2",
                    Name = "No-Answer"
                },
                new DictionaryEntity
                {
                    Code = "3",
                    Name = "Pending"
                },
                new DictionaryEntity
                {
                    Code = "4",
                    Name = "Qualified"
                }
            };
            this[DictionaryName.Gender] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "Male"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "FeMale"
                }
            };
            this[DictionaryName.SourceCode] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "SPS_400"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "Corp_400"
                },
                new DictionaryEntity
                {
                    Code = "2",
                    Name = "Web"
                },
                new DictionaryEntity
                {
                    Code = "3",
                    Name = "Marketo"
                },
                new DictionaryEntity
                {
                    Code = "4",
                    Name = "Telesales"
                }

            };
            this[DictionaryName.Category] = new List<DictionaryEntity>
            {
                new DictionaryEntity
                {
                    Code = "0",
                    Name = "Leads"
                },
                new DictionaryEntity
                {
                    Code = "1",
                    Name = "Opportunity"
                }

            };
        }

        public sealed class DictionaryName
        {
            public const string Priority = "Priority";
            public const string DateType = "DateType";
            public const string CaseStatus = "CaseStatus";
            public const string CaseType = "CaseType";
            public const string TaskType = "TaskType";
            public const string Gender = "Gender";
            public const string SourceCode = "SourceCode";
            public const string Category = "Category";
        }

    }
}
