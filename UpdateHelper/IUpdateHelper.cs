
namespace UpdateHelper {
    /// <summary>
    /// Use this to provide a central update loop to non monobehaviour objects.
    /// </summary>
    public interface IUpdateHelper {
        void RegisterDelegate(IUpdateDelegate updateDelegate);
        void UnregisterDelegate(IUpdateDelegate updateDelegate);
    }
}
