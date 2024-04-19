using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeApplepayAuthenticationSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeApplepayAuthenticationSubmitModel : AopObject
    {
        /// <summary>
        /// ApplePay核身鉴权结果，包括：支付密码、用户确认、数字签名
        /// </summary>
        [XmlArray("authentication_results")]
        [XmlArrayItem("authentication_result")]
        public List<AuthenticationResult> AuthenticationResults { get; set; }

        /// <summary>
        /// Apple端的设备ID
        /// </summary>
        [XmlElement("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// Apple绑定的BundleId
        /// </summary>
        [XmlElement("dpan_identifier")]
        public string DpanIdentifier { get; set; }

        /// <summary>
        /// 交易标识
        /// </summary>
        [XmlElement("transaction_identifier")]
        public string TransactionIdentifier { get; set; }
    }
}
