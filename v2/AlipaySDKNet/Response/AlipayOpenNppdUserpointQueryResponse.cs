using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenNppdUserpointQueryResponse.
    /// </summary>
    public class AlipayOpenNppdUserpointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 用户积分
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
