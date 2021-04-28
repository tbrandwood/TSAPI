namespace Domain
{
    public class Enums
    {
        public enum VariableType
        {
            ClosedEnd = 1,
            Quantity = 2,
            Character = 3,
            Logical = 4,
            Date = 5,
            Time = 6,
            Loop = 7
        }

        public enum ParentType
        {
            Grid = 1,
            Loop = 2,
            OtherSpecify = 3,
            //Ranking, numeric list, mixed
        }

        public enum UseType
        {
            Serial = 1, 
            Weight = 2,
            System = 3
        }

        //public enum Format
        //{
        //    Literal = 1, 
        //    Numeric = 2
        //}

        public enum AltLabelMode
        {
            Interview = 1,
            Analysis = 2
        }

        public enum ResultCode
        {
            Ok = 0
        }
    }
}
