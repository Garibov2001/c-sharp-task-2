using System;

namespace Azerfon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Company:
            AzerfonCompany company = new AzerfonCompany();

            // HR:
            AzerfoneHR leylaHR = new AzerfoneHR
            {
                HR_FullName = "Leyla Qasimova",
                CompanyObj = company
            };

            // Software Developer vacancy:
            AzerfoneVacancy softwareDev = new AzerfoneVacancy
            {
                Job_name = "Software Development",
                Job_salary = 1200,
                HR = leylaHR
            };


            // Project Manager vacancy:
            AzerfoneVacancy projectManag = new AzerfoneVacancy
            {
                Job_name = "Project Management",
                Job_salary = 1150,
                HR = leylaHR
            };


            // Project Manager vacancy:
            AzerfoneVacancy prodcutManag = new AzerfoneVacancy
            {
                Job_name = "Product Management",
                Job_salary = 1150,
                HR = leylaHR
            };

            Candidates candidate1 = new Candidates
            {
                FullName = "Mahmood Garibov",
                CertificateName = "Microsoft",
                InterviewLocation = "Baku"
            };

            Candidates candidate2 = new Candidates
            {
                FullName = "Eldar Garibov",
                CertificateName = "Cisco",
                InterviewZoomURL = "....."
            };

            Candidates candidate3 = new Candidates
            {
                FullName = "Zaur balayev",
                InterviewLocation = "Baku"
            };

            Candidates candidate4 = new Candidates
            {
                FullName = "Zabiq Garibov",
                CertificateName = "Microsoft",
                InterviewLocation = "Baku"
            };

            softwareDev.candidate_list.Add(candidate1);
            softwareDev.candidate_list.Add(candidate2);
            softwareDev.candidate_list.Add(candidate3);
            softwareDev.candidate_list.Add(candidate4);

            Console.WriteLine($"All Candidates: \n {softwareDev.GetAllCandidates()} \n");
            Console.WriteLine($"Accepted Candidates: \n {softwareDev.GetAcceptedCandidates()} \n");
            Console.WriteLine($"Rejected Candidates: \n {softwareDev.GetRejectedCandidates()} \n");
            Console.WriteLine($"Candidates with Location Interview: \n {softwareDev.GetCandidatedWithLocation()} \n");
            Console.WriteLine($"Candidates with Zoom Interview: \n {softwareDev.GetCandidatedWithZoom()} \n");



        }
    }
}
