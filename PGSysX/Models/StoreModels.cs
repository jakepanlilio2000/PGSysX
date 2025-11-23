using System.Collections.Generic;

namespace PGSysX.Anahaw
{
    public class StoreInfo
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string PuttyUser { get; set; }
        public string PuttyPass { get; set; }
        public string CouchHost { get; set; }
        public string MonitoringIP { get; set; }
        public string TPLinuxIP { get; set; }
    }

    public static class StoreRepository
    {
        // Helper to clean IPs (remove ports like :5984)
        public static string GetIpOnly(string hostWithPort)
        {
            if (string.IsNullOrEmpty(hostWithPort)) return "";
            return hostWithPort.Split(':')[0];
        }

        public static List<StoreInfo> Stores = new List<StoreInfo>
        {
            new StoreInfo { Name = "SF1", Code = "722", PuttyUser = "pgsanfernando722", PuttyPass = "pgsanfernando722", CouchHost = "192.92.92.50:5984", MonitoringIP = "127.0.0.85:10000", TPLinuxIP = "127.0.0.88:10000" },
            new StoreInfo { Name = "MASANTOL", Code = "313", PuttyUser = "pgmasantol313", PuttyPass = "pgmasantol313", CouchHost = "10.8.159.50:5984", MonitoringIP = "127.0.0.95:10000", TPLinuxIP = "127.0.0.95:10000" },
            new StoreInfo { Name = "SAN SIMON", Code = "642", PuttyUser = "pgsnsimon642", PuttyPass = "pgsnsimon642", CouchHost = "10.40.44.50:5984", MonitoringIP = "127.0.0.70:10000", TPLinuxIP = "127.0.0.102:10000" },
            new StoreInfo { Name = "APALIT", Code = "144", PuttyUser = "pgapalit144", PuttyPass = "pgapalit144", CouchHost = "192.144.144.50:5984", MonitoringIP = "127.0.0.10:10000", TPLinuxIP = "127.0.0.90:10000" },
            new StoreInfo { Name = "SF2", Code = "232", PuttyUser = "pgfernandino232", PuttyPass = "pgfernandino232", CouchHost = "192.232.232.50:5984", MonitoringIP = "127.0.0.15:10000", TPLinuxIP = "127.0.0.91:10000" },
            new StoreInfo { Name = "GUAGUA", Code = "244", PuttyUser = "pgguagua244", PuttyPass = "pgguagua244", CouchHost = "192.244.244.50:5984", MonitoringIP = "127.0.0.20:10000", TPLinuxIP = "127.0.0.92:10000" },
            new StoreInfo { Name = "FLORIDA", Code = "266", PuttyUser = "pgfloridablanca266", PuttyPass = "pgfloridablanca266", CouchHost = "192.32.32.50:5984", MonitoringIP = "127.0.0.25:10000", TPLinuxIP = "127.0.0.93:10000" },
            new StoreInfo { Name = "STO TOMAS", Code = "294", PuttyUser = "pgstotomas294", PuttyPass = "pgstotomas294", CouchHost = "10.8.141.50:5984", MonitoringIP = "127.0.0.30:10000", TPLinuxIP = "127.0.0.94:10000" },
            new StoreInfo { Name = "MEXICO", Code = "360", PuttyUser = "pgmexico360", PuttyPass = "pgmexico360", CouchHost = "10.8.193.50:5984", MonitoringIP = "127.0.0.40:10000", TPLinuxIP = "127.0.0.96:10000" },
            new StoreInfo { Name = "SINDALAN", Code = "374", PuttyUser = "pgsindalan374", PuttyPass = "pgsindalan374", CouchHost = "10.0.147.50:5984", MonitoringIP = "127.0.0.45:10000", TPLinuxIP = "127.0.0.97:10000" },
            new StoreInfo { Name = "STA RITA", Code = "383", PuttyUser = "pgstarita383", PuttyPass = "pgstarita383", CouchHost = "10.0.149.50:5984", MonitoringIP = "127.0.0.50:10000", TPLinuxIP = "127.0.0.98:10000" },
            new StoreInfo { Name = "BULAON", Code = "418", PuttyUser = "pgbulaon418", PuttyPass = "pgbulaon418", CouchHost = "10.0.191.50:5984", MonitoringIP = "127.0.0.55:10000", TPLinuxIP = "127.0.0.99:10000" },
            new StoreInfo { Name = "MACABEBE", Code = "438", PuttyUser = "pgmacabebe438", PuttyPass = "pgmacabebe438", CouchHost = "10.9.27.50:5984", MonitoringIP = "127.0.0.60:10000", TPLinuxIP = "127.0.0.100:10000" },
            new StoreInfo { Name = "CALIBUTBUT", Code = "449", PuttyUser = "pgcalibutbut449", PuttyPass = "pgcalibutbut449", CouchHost = "10.32.13.50:5984", MonitoringIP = "127.0.0.65:10000", TPLinuxIP = "127.0.0.101:10000" },
            new StoreInfo { Name = "BACOLOR", Code = "687", PuttyUser = "pgbacolor687", PuttyPass = "pgbacolor687", CouchHost = "10.40.53.50:5984", MonitoringIP = "127.0.0.75:10000", TPLinuxIP = "127.0.0.103:10000" },
            new StoreInfo { Name = "SAN AGUSTIN", Code = "697", PuttyUser = "pgsanagustin697", PuttyPass = "pgsanagustin697", CouchHost = "10.40.130.50:5984", MonitoringIP = "127.0.0.80:10000", TPLinuxIP = "127.0.0.104:10000" }
        };
    }
}