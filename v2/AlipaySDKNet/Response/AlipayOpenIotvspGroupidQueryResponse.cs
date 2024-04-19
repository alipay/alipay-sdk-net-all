using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspGroupidQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspGroupidQueryResponse : AopResponse
    {
        /// <summary>
        /// 封闭场景的机构用户库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }
    }
}
