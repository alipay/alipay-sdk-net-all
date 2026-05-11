using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerQueryResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerQueryResponseDTO : AopObject
    {
        /// <summary>
        /// 客户bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 海图客户社会统一信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 归属BD姓名
        /// </summary>
        [XmlElement("owner_bd_name")]
        public string OwnerBdName { get; set; }

        /// <summary>
        /// 归属BD工号
        /// </summary>
        [XmlElement("owner_bd_work_no")]
        public string OwnerBdWorkNo { get; set; }
    }
}
