using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionExecutionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionExecutionQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// 云函数名称
        /// </summary>
        [XmlElement("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// 执行状态  - SUCCESS  - FAIL  - DOING
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 是否为测试记录
        /// </summary>
        [XmlElement("test")]
        public bool Test { get; set; }

        /// <summary>
        /// trace ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
