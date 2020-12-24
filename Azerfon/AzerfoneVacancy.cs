using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;

namespace Azerfon
{
    class AzerfoneVacancy
    {
        public string Job_name { get; set; }
        public decimal Job_salary { get; set; }
        public AzerfoneHR HR { get; set; }
        public List<Candidates> candidate_list { get; set; } = new List<Candidates>();


        // Whole candidates who has either cert or not cert.
        public string GetAllCandidates()
        {
            return JsonSerializer.Serialize(candidate_list);
        }


        // Candidates with Microsoft cert are accepted
        public string GetAcceptedCandidates()
        {
            List<Candidates> acceptedList = new List<Candidates>();
            foreach (var candidate in candidate_list)
            {
                if(candidate.CertificateName == "Microsoft")
                {
                    acceptedList.Add(candidate);
                }
            }
            return JsonSerializer.Serialize(acceptedList);
        }


        // Candidates without Microsoft Cert are rejected
        public string GetRejectedCandidates()
        {
            List<Candidates> rejectedList = new List<Candidates>();
            foreach (var candidate in candidate_list)
            {
                if (candidate.CertificateName != "Microsoft")
                {
                    rejectedList.Add(candidate);
                }
            }
            return JsonSerializer.Serialize(rejectedList);
        }


        // Get candidates with location interview
        public string GetCandidatedWithLocation()
        {
            List<Candidates> candWithLocation = new List<Candidates>();
            foreach (var candidate in candidate_list)
            {
                if (candidate.InterviewLocation != null)
                {
                    candWithLocation.Add(candidate);
                }
            }
            return JsonSerializer.Serialize(candWithLocation);

        }
        

        // Get candidates with Zoom interview
        public string GetCandidatedWithZoom()
        {
            List<Candidates> candWithZoom = new List<Candidates>();
            foreach (var candidate in candidate_list)
            {
                if (candidate.InterviewZoomURL != null)
                {
                    candWithZoom.Add(candidate);
                }
            }
            return JsonSerializer.Serialize(candWithZoom);

        }


    }
}
