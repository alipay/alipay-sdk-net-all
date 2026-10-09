using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTianwutestModifyResponse.
    /// </summary>
    public class AlipaySecurityProdTianwutestModifyResponse : AopResponse
    {
        /// <summary>
        /// 测试
        /// </summary>
        [XmlElement("ceshi")]
        public string Ceshi { get; set; }
    }
}
