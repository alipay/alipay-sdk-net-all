using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataAlibabaSecuritydataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataAlibabaSecuritydataQueryModel : AopObject
    {
        /// <summary>
        /// 业务方调用唯一标识，可以是traceID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询服务名，由服务方给定
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 调用系统名
        /// </summary>
        [XmlElement("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 查询服务表名
        /// </summary>
        [XmlElement("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 设备ID，需要hash处理，不能反解析。
        /// </summary>
        [XmlElement("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
