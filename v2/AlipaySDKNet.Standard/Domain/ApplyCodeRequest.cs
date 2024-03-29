using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyCodeRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyCodeRequest : AopObject
    {
        /// <summary>
        /// 通码的业务身份，能唯一定位通码业务，包含码上的数据、路由规则
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// context_data，发码的上下文信息，比如pid，url等。此值为一个Map<string, string>类型的json串字符，传入规则如下： {"key1":"val2","key2":"val2"}。
        /// </summary>
        [XmlElement("context_data")]
        public string ContextData { get; set; }

        /// <summary>
        /// logo_url，logo图片地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }
    }
}
