using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseSourceuidPidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseSourceuidPidQueryModel : AopObject
    {
        /// <summary>
        /// 请求参数模型
        /// </summary>
        [XmlElement("source_uid_pid_query_request")]
        public SourceUidPidQueryRequest SourceUidPidQueryRequest { get; set; }
    }
}
