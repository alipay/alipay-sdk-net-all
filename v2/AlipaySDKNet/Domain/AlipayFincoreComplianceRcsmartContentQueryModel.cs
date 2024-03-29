using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartContentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcsmartContentQueryModel : AopObject
    {
        /// <summary>
        /// app_name为调用方系统名称(英文)，与分配的app_token一起做调用系统合法性校验
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// app_token为系统分配的密钥，与app_name一起做调用系统合法性校验
        /// </summary>
        [XmlElement("app_token")]
        public string AppToken { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
