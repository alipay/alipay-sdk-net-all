using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAgentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAgentQueryModel : AopObject
    {
        /// <summary>
        /// 创建或修改接口使用的外部请求号。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
