using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpecifiedAsset Data Structure.
    /// </summary>
    [Serializable]
    public class SpecifiedAsset : AopObject
    {
        /// <summary>
        /// 指定银行卡号
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 资产类型，用以标识资产大类。BANKCARD - 银行卡
        /// </summary>
        [XmlElement("pay_tool_type")]
        public string PayToolType { get; set; }

        /// <summary>
        /// 限定支付渠道的原因类型
        /// </summary>
        [XmlElement("specified_reason_code")]
        public string SpecifiedReasonCode { get; set; }
    }
}
