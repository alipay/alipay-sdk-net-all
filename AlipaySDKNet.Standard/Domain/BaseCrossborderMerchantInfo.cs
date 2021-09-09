using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BaseCrossborderMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BaseCrossborderMerchantInfo : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 组织名称，如：支付宝（中国）网络技术有限公司
        /// </summary>
        [XmlElement("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 如支付宝统一社会信用代码：91310115768225450T
        /// </summary>
        [XmlElement("uscc")]
        public string Uscc { get; set; }
    }
}
