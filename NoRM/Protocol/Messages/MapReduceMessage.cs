namespace NoRM.Protocol.Messages
{
    using Attributes;

    public class MapReduceMessage
    {
        public string mapreduce { get; set; }
        public string map { get; set; }
        public string reduce { get; set; }
        public bool keeptemp { get; set; }
        public string @out{ get; set;}
        public int? limit { get; set; }
        [MongoIgnoreIfNull]
        public string finalize { get; set; }
    }
}