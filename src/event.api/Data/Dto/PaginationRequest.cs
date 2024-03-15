namespace EventAPI;

public class PaginationRequest
{
    public int PageNumber {get; set;} = 1;
    public int NumberOfItems {get; set;} = 10;
}
