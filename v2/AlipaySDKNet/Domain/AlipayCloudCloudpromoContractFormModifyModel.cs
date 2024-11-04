using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoContractFormModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoContractFormModifyModel : AopObject
    {
        /// <summary>
        /// 智能体主体id
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 合同数据
        /// </summary>
        [XmlElement("data")]
        public RentContractViewVO Data { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 三方小程序id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
