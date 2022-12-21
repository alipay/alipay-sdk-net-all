using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceEcobindQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceEcobindQueryResponse : AopResponse
    {
        /// <summary>
        /// 可选项[Y,N]，Y表示有绑定数据，N表示没有绑定数据
        /// </summary>
        [XmlElement("bind")]
        public string Bind { get; set; }

        /// <summary>
        /// 绑定类型，可选项[SUB_MERCHANT,DIRECT_MERCHANT]
        /// </summary>
        [XmlElement("bind_type")]
        public string BindType { get; set; }

        /// <summary>
        /// 间联商户或者直连商户的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
