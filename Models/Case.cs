using System;

namespace LawOfficeManagementSystem.Models
{
    public class Case
    {
        public int CaseID { get; set; }
        public string CaseNumber { get; set; }
        public int ClientID { get; set; }
        public string CaseType { get; set; }
        public string CaseDescription { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Status { get; set; }
        public decimal TotalFees { get; set; }
        public decimal PaidAmount { get; set; }
        public string JudgeName { get; set; }
        public string CourtName { get; set; }
        public string AssignedLawyer { get; set; }
        public string Notes { get; set; }
    }
}