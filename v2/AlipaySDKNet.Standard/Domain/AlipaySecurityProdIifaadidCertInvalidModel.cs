using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdIifaadidCertInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdIifaadidCertInvalidModel : AopObject
    {
        /// <summary>
        /// 变更通知批次号
        /// </summary>
        [XmlElement("batch_number")]
        public string BatchNumber { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("bsn")]
        public string Bsn { get; set; }

        /// <summary>
        /// 变更通知的用户信息和文件签名
        /// </summary>
        [XmlArray("cdid_list")]
        [XmlArrayItem("iifaa_did_cdid_detail")]
        public List<IifaaDidCdidDetail> CdidList { get; set; }

        /// <summary>
        /// 凭证失效原因
        /// </summary>
        [XmlElement("similar_notice")]
        public string SimilarNotice { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
