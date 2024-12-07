namespace YukiDaemon {
    public record Profile(string Name, string FileName, string Arguments, string WorkingDirectory, List<KeyValuePair<string, string>> Environment, bool UseShellExecute, bool CreateNoWindow, bool AutoStart, int AfterStopped, decimal DelayForSeconds);

    public record Config(List<Profile> Profiles);
}
