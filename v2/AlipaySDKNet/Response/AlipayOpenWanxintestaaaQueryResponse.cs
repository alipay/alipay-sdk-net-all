using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenWanxintestaaaQueryResponse.
    /// </summary>
    public class AlipayOpenWanxintestaaaQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
