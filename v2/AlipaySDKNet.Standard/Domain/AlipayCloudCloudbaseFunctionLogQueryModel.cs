using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionLogQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseFunctionLogQueryModel : AopObject
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
        /// 是否倒序
        /// </summary>
        [XmlElement("desc")]
        public bool Desc { get; set; }

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
        /// 是否显示系统日志
        /// </summary>
        [XmlElement("show_system_log")]
        public bool ShowSystemLog { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start")]
        public string Start { get; set; }

        /// <summary>
        /// trace ID
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 查询参数
        /// </summary>
        [XmlElement("user_query")]
        public string UserQuery { get; set; }
    }
}
