using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAgentDelegationPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAgentDelegationPayModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 代买委托id
        /// </summary>
        [XmlElement("delegation_id")]
        public string DelegationId { get; set; }

        /// <summary>
        /// 预下单ID，通过请求alipay.trade.order.prepay接口获取预下单ID
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }
    }
}
