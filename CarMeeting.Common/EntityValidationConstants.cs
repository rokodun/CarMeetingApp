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
    }
}
