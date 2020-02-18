using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduJzPostPublishResponse.
    /// </summary>
    public class AlipayEcoEduJzPostPublishResponse : AopResponse
    {
        /// <summary>
        /// 职位编号
        /// </summary>
        [XmlElement("third_id")]
        public string ThirdId { get; set; }
    }
}
