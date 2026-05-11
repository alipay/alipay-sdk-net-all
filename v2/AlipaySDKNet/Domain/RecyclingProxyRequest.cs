using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecyclingProxyRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RecyclingProxyRequest : AopObject
    {
        /// <summary>
        /// 代卖人身份证件号
        /// </summary>
        [XmlElement("proxy_cert_no")]
        public string ProxyCertNo { get; set; }

        /// <summary>
        /// 代卖人姓名
        /// </summary>
        [XmlElement("proxy_name")]
        public string ProxyName { get; set; }

        /// <summary>
        /// 代卖人联系手机号
        /// </summary>
        [XmlElement("proxy_phone")]
        public string ProxyPhone { get; set; }
    }
}
