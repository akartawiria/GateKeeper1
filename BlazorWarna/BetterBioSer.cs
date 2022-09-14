using BlazorWarna.Modal;

namespace BlazorWarna
{
    public class BetterBioSer : IBetterBioSer
    {
        public List<Biodata>? BiodataList { get; set; }

        public int[] Coba { get; set; } = { 0, 0 };

        public int M { get; set; }
        public int N { get; set; }

        public BetterBioSer(int m, int n)
        {
            M = m;
            N = n;

            Coba[0] = M;

            Coba[1] = N;
        }

        public void AddBio(Biodata data)
        {
            BiodataList?.Add(data);
        }
    }
}
