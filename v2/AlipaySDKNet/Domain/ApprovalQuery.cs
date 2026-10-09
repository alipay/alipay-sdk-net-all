using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalQuery Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalQuery : AopObject
    {
        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
