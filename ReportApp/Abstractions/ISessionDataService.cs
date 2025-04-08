namespace ReportApp.Abstractions
{
    public interface ISessionDataService
    {
        void StartSessionLoad();

        void LoadData(string jsonFromFile);

        void EndSessionSave();
    }
}
