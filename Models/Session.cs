using System;
namespace LawOfficeManagementSystem.Models {
    public class Session {
        public int SessionID { get; set; }
        public int CaseID { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionType { get; set; }
        public string CourtName { get; set; }
        public string JudgeName { get; set; }
        public string SessionResult { get; set; }
        public string Attendees { get; set; }
        public string Notes { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}