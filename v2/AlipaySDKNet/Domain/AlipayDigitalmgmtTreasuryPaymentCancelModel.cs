using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtTreasuryPaymentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtTreasuryPaymentCancelModel : AopObject
    {
        /// <summary>
        /// 操作人员，取消主动付款需要传
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 业务参考号，必填
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，一般为系统名称
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 租户id，必传
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
