using BlazorWarna.Modal;
namespace BlazorWarna
{
    public class BioServices : IBioServices
    {
        public List<Biodata>? BiodataList { get; set; } = new List<Biodata>();
        // public List<Biodata>? biodataList = new();
        public int Coba { get; private set; }
        public int M { get; set; }
        public int N { get; set; }
    

        public BioServices(int m, int n)
        {
            M = m;
            N = n;
            Coba = Random.Shared.Next(M ,N);
         
        }
        public void AddBio(Biodata data)
        {
           BiodataList?.Add(data);
        }
    }
}