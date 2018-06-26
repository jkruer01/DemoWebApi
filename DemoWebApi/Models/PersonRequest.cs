using System;

namespace DemoWebApi.Models
{
    public class PersonRequest
    {
        public static readonly string AscendingSort = "ASC";
        public static readonly string DescendingSort = "DESC";

        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 20;

        public string Order { get; set; } = AscendingSort;

        public bool OrderAsc
        {
            get { return !string.Equals(Order, DescendingSort, StringComparison.OrdinalIgnoreCase); }
        }

        public string OrderBy { get; set; } = "LastName";

        public string FirstNameSuffix { get; set; }
        public string LastNameSuffix { get; set; }
        public int? MinimumAge { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? ZipCode { get; set; }
    }
}
