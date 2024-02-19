using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneStockTrustUserQueryResponse.
    /// </summary>
    public class AntfortuneStockTrustUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户支付宝注册使用的手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
