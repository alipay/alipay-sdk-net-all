using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiLinkFundResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiLinkFundResponse : AopObject
    {
        /// <summary>
        /// 基金数据
        /// </summary>
        [XmlElement("data")]
        public LinkFundResponse Data { get; set; }
    }
}
