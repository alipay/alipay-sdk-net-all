using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryHbFqPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryHbFqPayInfo : AopObject
    {
        /// <summary>
        /// 用户使用花呗分期支付的金额数
        /// </summary>
        [XmlElement("fq_amount")]
        public string FqAmount { get; set; }

        /// <summary>
        /// 用户使用花呗分期支付的分期数
        /// </summary>
        [XmlElement("user_install_num")]
        public string UserInstallNum { get; set; }
    }
}
