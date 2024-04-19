using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonMerchantsignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonMerchantsignQueryModel : AopObject
    {
        /// <summary>
        /// 授权场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 签约商户pid
        /// </summary>
        [XmlElement("sign_pid")]
        public string SignPid { get; set; }
    }
}
