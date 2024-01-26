namespace CleanArch.Application.DTOs.Common;

public class BaseTablePaging
{
	public int Offset { get; set; }
	public int Limit { get; set; }
	public int PageNum
	{
		set
		{
			_pageNum = value;
			Offset = (value - 1) * Limit;
		}
		get => _pageNum;
	}
	int _pageNum = 0;
	public string? SearchKey { get; set; }
}