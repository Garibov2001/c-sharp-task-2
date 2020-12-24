using System;
using System.Collections.Generic;
using System.Text;

namespace Azerfon
{
    class Candidates
    {
        private string _interviewZoomUrl;
        private string _interviewLocation;
        public string FullName { get; set; }
        public string CertificateName { get; set; } = null;

        //public Candidates(string argFullName, string argCert =null, string argInterviewLocation = null, string argInterviewZoom = null)
        //{
        //    FullName = argFullName;
        //    CertificateName = argCert;
        //    InterviewLocation = argInterviewLocation;
        //    InterviewZoomURL = argInterviewZoom;
        //}


        public string InterviewLocation
        {
            get { 
                return _interviewLocation; 
            }

            set { 
                //ya Location, ya da Zoom ola biler, yeni ikisinden biri
                if (_interviewZoomUrl == null)
                {
                    _interviewLocation = value;
                }
                else
                {
                    throw new Exception("Interview Zoom linki artiq teyin olunub.");
                }
            }
        }
        public string InterviewZoomURL
        {
            get
            {
                return _interviewZoomUrl;
            }

            set
            {
                //ya Location, ya da Zoom ola biler, yeni ikisinden biri
                if (_interviewLocation == null)
                {
                    _interviewZoomUrl = value;
                }
                else
                {
                    throw new Exception("Interview Locationu artiq teyin olunub.");
                }
            }
        }


    }
}
