﻿using CollectionViewChallenge.Models;
using CollectionViewChallenge.Services;
using MvvmHelpers;
using System.Collections.Generic;

namespace CollectionViewChallenge.ViewModels
{
    public class CollectionViewChallengeViewModel
        : BaseViewModel
    {
        private readonly ITimelineService _timelineService;

        public CollectionViewChallengeViewModel(ITimelineService timelineService)
        {
            _timelineService = timelineService;

            TimelineItems = _timelineService.GetTimelineItems(10);
        }

        public List<TimelineItem> TimelineItems { get; set; }
    }
}