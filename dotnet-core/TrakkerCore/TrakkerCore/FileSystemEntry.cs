using Newtonsoft.Json;

namespace TrakkerCore
{
    public class FileSystemEntry
    {
        [JsonProperty("id")]
        public int Identity { get; set; }

        [JsonProperty("full_path")]
        public string FullPath { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("children_first_id")]
        public int ChildrenFirstId { get; set; } = -1;

        [JsonProperty("children_last_id")]
        public int ChildrenLastId { get; set; } = -1;

        public FileSystemEntry(int id, string fullPath, long size)
        {
            this.Identity = id;
            this.FullPath = fullPath;
            this.Size = size;
        }
    }
}
