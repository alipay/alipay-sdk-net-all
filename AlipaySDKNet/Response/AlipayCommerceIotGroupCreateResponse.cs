using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotGroupCreateResponse.
    /// </summary>
    public class AlipayCommerceIotGroupCreateResponse : AopResponse
    {
        /// <summary>
        /// 分组创建成功的id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }
    }
}
