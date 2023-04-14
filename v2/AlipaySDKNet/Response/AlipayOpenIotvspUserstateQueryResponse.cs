using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserstateQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspUserstateQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回用户是否在库（1：在库，2：不在库）
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
