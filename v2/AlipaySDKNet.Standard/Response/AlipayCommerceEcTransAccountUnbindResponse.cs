using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountUnbindResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountUnbindResponse : AopResponse
    {
        /// <summary>
        /// 解绑结果 成功-SUCCESS 失败-FAIL
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
