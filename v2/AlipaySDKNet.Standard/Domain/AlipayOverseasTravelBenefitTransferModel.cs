using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelBenefitTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelBenefitTransferModel : AopObject
    {
        /// <summary>
        /// 权益同步时传递的统一权益池权益id
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 业务幂等号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// ONLINE代表上线 PAUSE代表暂停权益
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
