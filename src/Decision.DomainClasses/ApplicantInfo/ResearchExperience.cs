﻿using System;
using Decision.DomainClasses.Identity;
using Decision.Framework.Domain.Entities.Tracking;

namespace Decision.DomainClasses.ApplicantInfo
{
    public class ResearchExperience : TrackableEntity<long, User>
    {
        #region Properties

        public double Score { get; set; }

        public string Institution { get; set; }

        public DateTime BeginYear { get; set; }

        public DateTime? EndYear { get; set; }

        public string Lessons { get; set; }

        public string InstitutionAddress { get; set; }

        public string InstitutionPhoneNumber { get; set; }

        #endregion

        #region NavigationProperties

        public Applicant Applicant { get; set; }

        public long ApplicantId { get; set; }

        #endregion
    }
}