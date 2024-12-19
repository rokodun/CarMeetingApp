namespace CarMeeting.Common
{
    public static class EntityValidationConstants
    {
        public static class Event
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
            public const int LocationMinLength = 3;
            public const int LocationMaxLength = 70;
            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 300;
            public const string EventDateFormat = "dd/MM/yyyy";
        }

        public static class Car
        {
            public const int MakeMinLength = 2;
            public const int MakeMaxLength = 40;
            public const int ModelMinLength = 1;
            public const int ModelMaxLength = 30;
            public const int ColorMinLength = 3;
            public const int ColorMaxLength = 80;
        }
    }
}
