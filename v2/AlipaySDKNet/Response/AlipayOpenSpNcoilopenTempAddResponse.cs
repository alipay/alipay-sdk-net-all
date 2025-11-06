using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTempAddResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenTempAddResponse : AopResponse
    {
        /// <summary>
        /// 业务id，与申请单id唯一对应
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 该条数据对应的唯一标识
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
