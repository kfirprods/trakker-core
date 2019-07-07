using System.Collections.Generic;
using Newtonsoft.Json;

namespace TrakkerCore
{
    public class SnapshotMetadata
    {
        [JsonProperty("root_path")]
        public string RootPath { get; set; }

        [JsonProperty("drive_size")]
        public int DriveSize { get; set; }

        [JsonProperty("clusters_count")]
        public int ClustersCount { get; set; }

        public IEnumerable<string> GetClusterFileNames()
        {
            for (var clusterIndex = 0; clusterIndex < this.ClustersCount; clusterIndex++)
            {
                yield return GenerateClusterName(clusterIndex);
            }
        }

        public static string GenerateClusterName(int clusterIndex)
        {
            return $"snapshot_cluster_{clusterIndex}.json";
        }
    }
}
