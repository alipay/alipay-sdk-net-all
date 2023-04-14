using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdMygetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdMygetQueryModel : AopObject
    {
        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 座机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
