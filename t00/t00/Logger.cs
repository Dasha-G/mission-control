namespace Travelling
{
    public class Logger<T>
    {
        private List<T> entries = new List<T>();
        public void Add(T entry)
        {
            entries.Add(entry);
        }

        public void Flush(string FilePath)
        {
            foreach (T entry in entries)
            {
                File.AppendAllText(FilePath, entry.ToString() + "\n");
            }
        }
    }
}
