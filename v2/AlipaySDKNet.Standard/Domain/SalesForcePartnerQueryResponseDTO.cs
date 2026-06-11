using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SalesForcePartnerQueryResponseDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SalesForcePartnerQueryResponseDTO : AopObject
    {
        /// <summary>
        /// 伙伴bid
        /// </summary>
        [XmlElement("bid")]
        public string Bid { get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 伙伴名称
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

        /// <summary>
        /// 伙伴pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
