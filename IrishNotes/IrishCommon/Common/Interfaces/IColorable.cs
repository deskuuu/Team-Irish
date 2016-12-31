namespace IrishNotes.Common.Interfaces
{
    using Enumerations;

    public interface IColorable
    {
        void ChangeTextColorByUserChoiceWrite(TextColorType color, string text);
    }
}
