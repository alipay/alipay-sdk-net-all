using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplySubAccountAndBindOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ApplySubAccountAndBindOrder : AopObject
    {
        /// <summary>
        /// 机构ID，如ZL6、ZL7
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 商户结算pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 上游申请请求单号，source + outBizNo 用于幂等。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，通常为业务系统名，source + outBizNo 用于幂等。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 财资业务识别码。用于财资识别需要使用的主账户。由财资预先分配。联系周丹
        /// </summary>
        [XmlElement("treasury_business_type")]
        public string TreasuryBusinessType { get; set; }
    }
}
