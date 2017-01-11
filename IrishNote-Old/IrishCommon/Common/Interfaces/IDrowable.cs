namespace IrishNotes.Common.Interfaces
{
    public interface IDrowable
    {
        void SetCursorPositionAt(int left, int top);

        void Draw();

        void Clean();
    }
}
