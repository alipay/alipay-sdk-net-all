using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAgentPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAgentPayModel : AopObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付并签约的签约参数
        /// </summary>
        [XmlElement("agreement_sign_params")]
        public AgentSignParams AgreementSignParams { get; set; }

        /// <summary>
        /// 预下单ID，通过请求alipay.trade.order.prepay接口获取预下单ID
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// 根据支付宝提供的秘钥信息，对手机号或者联登支付宝账号进行加密后的字符串；
        /// </summary>
        [XmlElement("user_token")]
        public string UserToken { get; set; }

        /// <summary>
        /// 如果加密的是手机号，传固定值 encrypt_phone； 如果加密的是联登账号，传固定值encrypt_uid；
        /// </summary>
        [XmlElement("user_token_type")]
        public string UserTokenType { get; set; }
    }
}
