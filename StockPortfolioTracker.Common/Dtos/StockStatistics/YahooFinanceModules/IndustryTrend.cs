﻿namespace StockPortfolioTracker.Common;

public class IndustryTrend : BaseApiResponse
{
	#region Properties
	public string? Symbol { get; set; }
	public ResultFormatDto? PeRatio { get; set; }
	public ResultFormatDto? PegRatio { get; set; }
	public List<IndustryTrendEstimates>? Estimates { get; set; }
	#endregion
}

public class IndustryTrendEstimates
{
	#region Properties
	public string? Period { get; set; }
	public ResultFormatDto? Growth { get; set; }
	#endregion
}