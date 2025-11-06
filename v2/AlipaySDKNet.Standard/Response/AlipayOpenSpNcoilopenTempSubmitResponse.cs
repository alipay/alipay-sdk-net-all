using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenTempSubmitResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenTempSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提交后，会生成一个唯一id，用于后续创单
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
