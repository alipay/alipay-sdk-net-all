using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenContentUsereventcontentQueryResponse.
    /// </summary>
    public class AlipayOpenContentUsereventcontentQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务消息
        /// </summary>
        [XmlElement("biz_message")]
        public string BizMessage { get; set; }

        /// <summary>
        /// 触点供给内容列表
        /// </summary>
        [XmlElement("point_supplies_data")]
        public string PointSuppliesData { get; set; }
    }
}
