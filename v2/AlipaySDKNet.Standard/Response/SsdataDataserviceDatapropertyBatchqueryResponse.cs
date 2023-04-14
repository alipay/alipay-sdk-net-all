using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceDatapropertyBatchqueryResponse.
    /// </summary>
    public class SsdataDataserviceDatapropertyBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 服务端处理响应id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 描述了返回的结果体的key名
        /// </summary>
        [XmlElement("result_key")]
        public string ResultKey { get; set; }

        /// <summary>
        /// 返回的response数据
        /// </summary>
        [XmlElement("result_response")]
        public string ResultResponse { get; set; }

        /// <summary>
        /// 描述渠道执行操作返回的result类型
        /// </summary>
        [XmlElement("result_type")]
        public string ResultType { get; set; }

        /// <summary>
        /// 数据渠道返回结果体的value值
        /// </summary>
        [XmlElement("result_value")]
        public string ResultValue { get; set; }
    }
}
