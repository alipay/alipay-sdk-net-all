using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMerchantTypeQueryResponse.
    /// </summary>
    public class AntMerchantExpandMerchantTypeQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回值及对应含义如下：  indirect-纯间连商户  duplex-间连直连双重身份商户  other-其他类型
        /// </summary>
        [XmlElement("indirect_bind_type")]
        public string IndirectBindType { get; set; }

        /// <summary>
        /// 返回值及对应含义  koubei-口碑商户  other-非口碑商户
        /// </summary>
        [XmlElement("kb_type")]
        public string KbType { get; set; }

        /// <summary>
        /// 返回值及对应汗液如下：  offline_pay_signed-已签约线下支付  other-其他情况
        /// </summary>
        [XmlElement("merchant_sign_type")]
        public string MerchantSignType { get; set; }
    }
}
