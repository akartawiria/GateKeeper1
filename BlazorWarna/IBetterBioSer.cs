using BlazorWarna.Modal;

namespace BlazorWarna
{
    public interface IBetterBioSer
    {
        List<Biodata>? BiodataList { get; set; }
        int[] Coba { get; set; }
        int M { get; set; }
        int N { get; set; }

        void AddBio(Biodata data);
    }
}