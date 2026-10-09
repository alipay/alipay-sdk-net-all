using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTianwutestModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTianwutestModifyModel : AopObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("tianwutest")]
        public string Tianwutest { get; set; }
    }
}
