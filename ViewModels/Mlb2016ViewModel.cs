using System.ComponentModel.DataAnnotations;

namespace ProjectDatabase.ViewModels
{
    public class Mlb2016ViewModel
    {
        public Mlb2016ViewModel()
        {

        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        public int Date { get; set; }
        [Required(ErrorMessage = "Rot is required.")]
        public int Rot { get; set; }
        [Required(ErrorMessage = "VH is required.")]
        public string VH { get; set; }
        [Required(ErrorMessage = "Team is required.")]
        public string Team { get; set; }
        [Required(ErrorMessage = "Pitcher is required.")]
        public string Pitcher { get; set; }
        [Required(ErrorMessage = "_1st is required.")]
        public int _1st { get; set; }
        [Required(ErrorMessage = "_2nd is required.")]
        public int _2nd { get; set; }
        [Required(ErrorMessage = "_3rd is required.")]
        public int _3rd { get; set; }
        [Required(ErrorMessage = "_4th is required.")]
        public int _4th { get; set; }
        [Required(ErrorMessage = "_5th is required.")]
        public int _5th { get; set; }
        [Required(ErrorMessage = "_6th is required.")]
        public int _6th { get; set; }
        [Required(ErrorMessage = "_7th is required.")]
        public int _7th { get; set; }
        [Required(ErrorMessage = "_8th is required.")]
        public int _8th { get; set; }
        [Required(ErrorMessage = "_9th is required.")]
        public int _9th { get; set; }
        [Required(ErrorMessage = "Final is required.")]
        public int Final { get; set; }
        [Required(ErrorMessage = "Open is required.")]
        public int Open { get; set; }
        [Required(ErrorMessage = "Close is required.")]
        public int Close { get; set; }
        [Required(ErrorMessage = "OpenOU is required.")]
        public double Run_line { get; set; }
        [Required(ErrorMessage = "OpenOU is required.")]
        public int column20 { get; set; }
        [Required(ErrorMessage = "OpenOU is required.")]
        public double OpenOU { get; set; }
        [Required(ErrorMessage = "OpenOU is required.")]
        public int column22 { get; set; }
        [Required(ErrorMessage = "CloseOU is required.")]
        public double CloseOU { get; set; }
        [Required(ErrorMessage = "CloseOU is required.")]
        public int column24 { get; set; }
    }
}
