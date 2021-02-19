using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbFqPayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HbFqPayInfo : AopObject
    {
        /// <summary>
        /// 用户使用花呗分期支付的分期数
        /// </summary>
        [XmlElement("user_install_num")]
        public string UserInstallNum { get; set; }
    }
}
