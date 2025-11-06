using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCreditExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentCreditExtInfoDTO : AopObject
    {
        /// <summary>
        /// 纯代扣签约场景该订单是否使用租安盾风控。不传默认不使用
        /// </summary>
        [XmlElement("fee_risk_model")]
        public string FeeRiskModel { get; set; }
    }
}
