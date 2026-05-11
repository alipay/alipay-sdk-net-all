using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdSecdeviceInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdSecdeviceInitializeModel : AopObject
    {
        /// <summary>
        /// 版本号，默认为2.0
        /// </summary>
        [XmlElement("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// 安全数据
        /// </summary>
        [XmlElement("sec_data")]
        public string SecData { get; set; }
    }
}
