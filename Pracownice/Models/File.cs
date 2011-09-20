namespace Pracownice.Models
{
    public class File
    {
        public int FileID { get; set; }
        public int PracownicaId { get; set; }

        public string TypeOfUsed { get; set; }
        public string Description { set; get; }

        public string Url { get; set; }
        public string thumbUrl { set; get; }

        public UploadedFileModel fileModel { get; set; }

        public virtual Pracownica pracownica { get; set; }
    }
}