﻿using System;

namespace TimeTracker.View
{
    public class EventValues
    {
        public string entryId { get; set; }
        public string taskId { get; set; }
        public string taskName { get; set; }
        public int listId { get; set; }

        public TimeSpan ts { get; set; }
        public TimeSpan idle { get; set; }
        public TimeSpan active { get; set; }
        public TimeSpan activeDelta { get; set; }
        public DateTimeOffset lastPostedTs { get; set; }
        public string screenShotPath { get; set; }

    }
}
