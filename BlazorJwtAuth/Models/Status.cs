using System.ComponentModel.DataAnnotations;

namespace BlazorJwtAuth.Models
{
    public class Status
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}
