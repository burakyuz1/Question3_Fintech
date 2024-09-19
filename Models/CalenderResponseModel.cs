namespace Question3_Fintech.Models
{
    public record CalenderResponseModel(int Year, MonthRecord[] Months);

    public record MonthRecord(byte MonthIndex, DayRecord[] Days, bool IsSelectable);

    public record DayRecord(
        byte DayTitle,
        DayOfWeek DayOfWeek,
        int PositionCount,
        ProfitLossData ProfitLossData
    );

    /// <summary>
    /// model for selection of Profit in USDT or %, it should render according to selection of user
    /// </summary>
    /// <param name="Usdt"></param>
    /// <param name="Percentage"></param>
    public record ProfitLossData(
        decimal Usdt,
        decimal Percentage
    );
}
