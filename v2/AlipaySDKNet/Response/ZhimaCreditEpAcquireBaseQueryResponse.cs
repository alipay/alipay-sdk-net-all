using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAcquireBaseQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAcquireBaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据集
        /// </summary>
        [XmlElement("data")]
        public AcquirePayFlow Data { get; set; }

        /// <summary>
        /// 查得标记：true，false
        /// </summary>
        [XmlElement("data_found")]
        public bool DataFound { get; set; }
    }
}
