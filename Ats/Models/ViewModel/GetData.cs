﻿using Ats.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Ats.Models.ViewModel
{
    public class GetData
    {
        public List<InterPersonalInfoViewModel> GetAllPersonalInfo()
        {
            List<InterPersonalInfoViewModel> OBJ1 = new List<InterPersonalInfoViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var list1 = db.InterPersonalInfo.ToList();
                    if (list1 != null)
                    {
                        var count = list1.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                InterPersonalInfoViewModel obj11 = new InterPersonalInfoViewModel();
                                obj11.CandidateId = list1[i].CandidateId;
                                obj11.FirstName = list1[i].FirstName;
                                obj11.LastName = list1[i].LastName;
                                obj11.MobileNo1 = list1[i].MobileNo1;
                                obj11.MobileNo2 = list1[i].MobileNo2;
                                obj11.Age = list1[i].Age;
                                obj11.MaritalStaus = list1[i].MaritalStaus;
                                obj11.AddressPresent = list1[i].AddressPresent;
                                obj11.StatePresent = list1[i].StatePresent;
                                obj11.StatePast = list1[i].StatePast;
                                obj11.CityPresent = list1[i].CityPresent;
                                obj11.CityPast = list1[i].CityPast;
                                obj11.PincodePresent = list1[i].PincodePresent;
                                obj11.PinCodePast = list1[i].PinCodePast;
                                obj11.TotalExperienceInYear = list1[i].TotalExperienceInYear;
                                obj11.EarliestJoinDate = list1[i].EarliestJoinDate;
                                obj11.SalaryExpectation = list1[i].SalaryExpectation;
                                obj11.Vehicle = list1[i].Vehicle;
                                obj11.JobSource = list1[i].JobSource;
                                obj11.NightShift = list1[i].NightShift;
                                obj11.IsReference = list1[i].IsReference;
                                obj11.ReferenceName = list1[i].ReferenceName;
                                obj11.ReferenceMobileNo = list1[i].ReferenceMobileNo;
                                obj11.DateOfBirth = list1[i].DateOfBirth;
                                obj11.EmailId = list1[i].EmailId;
                                obj11.OtherCertification = list1[i].OtherCertification;
                                obj11.Gender = list1[i].Gender;
                                obj11.NoOfChildren =Convert.ToInt32(list1[i].NoOfChildren);
                                obj11.AppliedForDepartment = list1[i].AppliedForDepartment;
                                obj11.AppliedForDesignation = list1[i].AppliedForDesignation;
                                obj11.AddressPast = list1[i].AddressPast;
                                obj11.ReferenceDesignation = list1[i].ReferenceDesignation;
                                OBJ1.Add(obj11);
                            }
                        }
                    }
                    return OBJ1;
                }
            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }
        public List<InterPreEmpDetailViewModel> GetAllPreviousEmplpoyementDetails()
        {
            List<InterPreEmpDetailViewModel> OBJ1 = new List<InterPreEmpDetailViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var list1 = db.InterPreEmpDetail.ToList();
                    if (list1 != null)
                    {
                        var count = list1.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                InterPreEmpDetailViewModel obj11 = new InterPreEmpDetailViewModel();
                                obj11.EmploymentId = list1[i].EmploymentId;
                                obj11.CandidateId = list1[i].CandidateId;
                                obj11.City = list1[i].City;
                                obj11.CompanyName = list1[i].CompanyName;
                                obj11.Designation = list1[i].Designation;
                                obj11.WorkFrom = list1[i].WorkFrom;
                                obj11.WorkTo = list1[i].WorkTo;
                                obj11.CtcMonth = list1[i].CtcMonth;
                                OBJ1.Add(obj11);
                            }
                        }
                    }
                    return OBJ1;
                }

            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }
        public List<InterReferenceViewModel> GetReferenceInfo()
        {
            List<InterReferenceViewModel> interReferences = new List<InterReferenceViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var list1 = db.InterReference.ToList();
                    if (list1 != null)
                    {
                        var count = list1.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                InterReferenceViewModel interReference = new InterReferenceViewModel();
                                interReference.ReferenceId = list1[i].ReferenceId;
                                interReference.CandidateId = list1[i].CandidateId;
                                interReference.CompanyName = list1[i].CompanyName;
                                interReference.PersonName = list1[i].PersonName;
                                interReference.Designation = list1[i].Designation;
                                interReference.ContactNo = list1[i].ContactNo;
                                interReferences.Add(interReference);
                            }
                        }
                    }
                    return interReferences;
                }

            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }
        public List<InterEducBackgroundViewModel> GetAllEducationBackground()
        {
            List<InterEducBackgroundViewModel> OBJ1 = new List<InterEducBackgroundViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var list1 = db.InterEducBackground.ToList();
                    if (list1 != null)
                    {
                        var count = list1.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                InterEducBackgroundViewModel obj11 = new InterEducBackgroundViewModel();
                                obj11.EducationalId = list1[i].EducationalId;
                                obj11.CandidateId = list1[i].CandidateId;
                                obj11.CourseDegreeName = list1[i].CourseDegreeName;
                                obj11.BoardUniversityName = list1[i].BoardUniversityName;
                                obj11.PassingYear = list1[i].PassingYear;
                                obj11.GradePercentage = list1[i].GradePercentage;
                                OBJ1.Add(obj11);

                            }
                        }
                    }
                    return OBJ1;
                }

            }
            catch (Exception ex)
            {
                throw ex; ;
            }
        }
        public List<CityViewModel> GetAllCity()
        {

            List<CityViewModel> cities = new List<CityViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var CityList = db.City.ToList();
                    if (CityList != null)
                    {
                        var count = CityList.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                CityViewModel city = new CityViewModel();
                                city.CityId = CityList[i].CityId;
                                city.CityNamePast = CityList[i].CityName;
                                city.CityNamePresant = CityList[i].CityName;
                                cities.Add(city);
                            }
                        }
                    }
                    return cities;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<StateViewModel> GetAllState()
        {
            List<StateViewModel> states = new List<StateViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var StateList = db.State.ToList();
                    if (StateList != null)
                    {
                        var count = StateList.Count();
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                StateViewModel state = new StateViewModel();
                                state.StateId = StateList[i].StateId;
                                state.StateNamePast = StateList[i].StateName;
                                state.StateNamePresant = StateList[i].StateName;
                                states.Add(state);
                            }
                        }
                    }
                    return states;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DepartmentViewModel> GetAllDepartment()
        {
            List<DepartmentViewModel> departments = new List<DepartmentViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var departmentList = db.Department.ToList();
                    if (departmentList != null)
                    {
                        var count = departmentList.Count;
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                DepartmentViewModel dept = new DepartmentViewModel();
                                dept.DepartmentId = departmentList[i].DepartmentId;
                                dept.DepartmentName = departmentList[i].DepartmentName;
                                departments.Add(dept);
                            }
                        }
                    }
                    return departments;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<DesignationViewModel> GetAllDesignation()
        {
            List<DesignationViewModel> designations = new List<DesignationViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var designationList = db.Designation.ToList();
                    if (designationList != null)
                    {
                        var count = designationList.Count;
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                DesignationViewModel designation = new DesignationViewModel();
                                designation.DesignationId = designationList[i].DesignationId;
                                designation.DepartmentId = designationList[i].DepartmentId;
                                designation.DesignationName = designationList[i].DesignationName;
                                designations.Add(designation);
                            }
                        }
                    }
                    return designations;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<FeedbackViewModel> GetCandidatefeedback()
        {
            List<FeedbackViewModel> feedbacks = new List<FeedbackViewModel>();
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var feedbackList = db.Feedbacks.ToList();
                    if (feedbackList != null)
                    {

                        var count = feedbackList.Count;
                        if (count > 0)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                FeedbackViewModel feedback = new FeedbackViewModel();
                                feedback.CandidateId = feedbackList[i].CandidateId;
                                 feedback.InterviewDate = Convert.ToString(feedbackList[i].InterviewDate);
                                feedback.CandidateStatus = feedbackList[i].CandidateStatus;
                                feedback.OtherComments = feedbackList[i].OtherComments;
                                feedback.IsFeddbackAdded = feedbackList[i].IsFeddbackAdded;
                                feedbacks.Add(feedback);
                            }
                        }
                    }
                    return feedbacks;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        ApplicationDbContext db = new ApplicationDbContext();
        public GridPreInterRegisterViewModel ReportById(int id)
        {
            try
            {
                GridPreInterRegisterViewModel Candidate = new GridPreInterRegisterViewModel();
                InterPersonalInfoViewModel perSonalInfo = new InterPersonalInfoViewModel();
                List<InterPreEmpDetailViewModel> preEmployementDetail = new List<InterPreEmpDetailViewModel>();
                List<InterEducBackgroundViewModel> eduBackGround = new List<InterEducBackgroundViewModel>();
                List<InterReferenceViewModel> reference = new List<InterReferenceViewModel>();
                List<LanguageViewModel> languages = new List<LanguageViewModel>();
                List<FeedbackViewModel> feedbacks = new List<FeedbackViewModel>();
                CityViewModel cities = new CityViewModel();
                StateViewModel states = new StateViewModel();
                DepartmentViewModel departments = new DepartmentViewModel();
                DesignationViewModel designations = new DesignationViewModel();
                perSonalInfo =                     (                    from p in db.InterPersonalInfo                    where (p.CandidateId == id)                    select new InterPersonalInfoViewModel()
                    {                        CandidateId = p.CandidateId,                        FirstName = p.FirstName,                        LastName = p.LastName,                        MobileNo1 = p.MobileNo1,                        MobileNo2 = p.MobileNo2,                        DateOfBirth = p.DateOfBirth,                        Age = p.Age,                        Gender = p.Gender,                        MaritalStaus = p.MaritalStaus,                        NoOfChildren = p.NoOfChildren,                        AddressPresent = p.AddressPresent,                        StatePresent = p.StatePresent,                        CityPresent = p.CityPresent,                        PincodePresent = p.PincodePresent,                        AddressPast = p.AddressPast,                        StatePast = p.StatePast,                        CityPast = p.CityPast,                        PinCodePast = p.PinCodePast,                        AppliedForDepartment = p.AppliedForDepartment,                        AppliedForDesignation = p.AppliedForDesignation,                        TotalExperienceInYear = p.TotalExperienceInYear,                        EarliestJoinDate = p.EarliestJoinDate,                        SalaryExpectation = p.SalaryExpectation,                        Vehicle = p.Vehicle,                        JobSource = p.JobSource,                        NightShift = p.NightShift,                        IsReference = p.IsReference,                        ReferenceName = p.ReferenceName,                        ReferenceDesignation = p.ReferenceDesignation,                        ReferenceMobileNo = p.ReferenceMobileNo,                        EmailId = p.EmailId,                        OtherCertification = p.OtherCertification,                        ///OtherComments=p.OtherComments,                        //CandidateStatus = p.CandidateStatus,                        //InterviewDate = p.InterviewDate
                    }).FirstOrDefault();

                Candidate.PersonalInfo = perSonalInfo;
                preEmployementDetail = (from p in db.InterPreEmpDetail
                                        where (p.CandidateId == id)
                                        select new InterPreEmpDetailViewModel
                                        {
                                            EmploymentId = p.EmploymentId,
                                            CandidateId = p.CandidateId,
                                            City = p.City,
                                            CompanyName = p.CompanyName,
                                            Designation = p.Designation,
                                            WorkFrom = p.WorkFrom,
                                            WorkTo = p.WorkTo,
                                            CtcMonth = p.CtcMonth
                                        }).ToList();

                Candidate.PreviousEmploymentDetail = preEmployementDetail;

                eduBackGround = (from p in db.InterEducBackground
                                 where (p.CandidateId == id)
                                 select new InterEducBackgroundViewModel()
                                 {
                                     EducationalId = p.EducationalId,
                                     CandidateId = p.CandidateId,
                                     BoardUniversityName = p.BoardUniversityName,
                                     CourseDegreeName = p.CourseDegreeName,
                                     PassingYear = p.PassingYear,
                                     GradePercentage = p.GradePercentage
                                 }).ToList();
                Candidate.EducationBackground = eduBackGround;

                reference = (from p in db.InterReference
                             where (p.CandidateId == id)
                             select new InterReferenceViewModel()
                             {
                                 ReferenceId = p.ReferenceId,
                                 CandidateId = p.CandidateId,
                                 PersonName = p.PersonName,
                                 CompanyName = p.CompanyName,
                                 Designation = p.Designation,
                                 ContactNo = p.ContactNo
                             }).ToList();
                Candidate.Reference = reference;
                //Candidate.Language = new List<LanguageViewModel>();

                languages = (from l in db.InterLanguages
                             where l.CandidateId == id
                             select new LanguageViewModel
                             {
                                 LanguageType = l.LanguageType,
                                 Read = l.Read,
                                 Write = l.Write,
                                 Speak = l.Speak
                             }).ToList();
                Candidate.Language = languages;

                return Candidate;
            }
            catch (Exception ex)
            {
                //ViewBag.errormessage = string.IsNullOrEmpty(Convert.ToString(ex.InnerException)) ? ex.Message.ToString() : ex.InnerException.ToString();
                return null;
            }
        }
    }
}