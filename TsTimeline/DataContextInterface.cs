namespace TsTimeline
{
    public interface IHoldClipDataContext
    {
        double StartFrame { get; set; }
        double EndFrame { get; set; }
        double StartValue { get; set; }
        double EndValue { get; set; }
    }

    public interface ITriggerClipDataContext
    {
        double Frame { get; set; }
    }
}