using BlazorWarna.Modal;

namespace BlazorWarna
{
    public interface IBioServices
    {
        List<Biodata>? BiodataList { get; set; }
        int Coba { get; }
        int M { get; set; }
        int N { get; set; }

        void AddBio(Biodata data);
    }
}