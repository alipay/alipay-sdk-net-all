using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceAppinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceAppinfoQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 输入参数的额外信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 目前服务业务请求的上下文
        /// </summary>
        [XmlElement("request_context")]
        public string RequestContext { get; set; }
    }
}
