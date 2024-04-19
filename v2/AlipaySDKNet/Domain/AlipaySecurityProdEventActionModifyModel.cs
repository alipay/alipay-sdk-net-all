using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdEventActionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdEventActionModifyModel : AopObject
    {
        /// <summary>
        /// 返回描述
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 调用风洞唯一标识
        /// </summary>
        [XmlElement("socplt_key")]
        public string SocpltKey { get; set; }

        /// <summary>
        /// action处置状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
