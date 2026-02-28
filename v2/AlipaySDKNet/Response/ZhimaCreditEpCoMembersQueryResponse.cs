using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCoMembersQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCoMembersQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("data")]
        public EpCoMemberDataInfo Data { get; set; }

        /// <summary>
        /// 查得标记
        /// </summary>
        [XmlElement("data_found")]
        public bool DataFound { get; set; }
    }
}
