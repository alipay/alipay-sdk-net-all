using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleCreditServiceEvaluateResponse.
    /// </summary>
    public class AlipayCommerceRecycleCreditServiceEvaluateResponse : AopResponse
    {
        /// <summary>
        /// 是否准入（true 表示准入，false 表示不准入）
        /// </summary>
        [XmlElement("permit")]
        public bool Permit { get; set; }

        /// <summary>
        /// 预授权金额比例（如 "30" 表示 30%，通常以字符串形式表示百分比数值）
        /// </summary>
        [XmlElement("pre_settlement_ratio")]
        public string PreSettlementRatio { get; set; }

        /// <summary>
        /// 信用取评估单号
        /// </summary>
        [XmlElement("risk_order_no")]
        public string RiskOrderNo { get; set; }
    }
}
