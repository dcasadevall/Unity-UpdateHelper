
namespace UpdateHelper {
    /// <summary>
    /// Use this in conjunction with UpdateHelper in order to provide an Update loop for non monobehaviour objects.
    /// </summary>
    public interface IUpdateDelegate {
        void Update();
    }
}
