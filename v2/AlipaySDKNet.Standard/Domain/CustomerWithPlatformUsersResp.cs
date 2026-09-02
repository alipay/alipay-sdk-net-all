using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomerWithPlatformUsersResp Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerWithPlatformUsersResp : AopObject
    {
        /// <summary>
        /// 归属于bd的海图客户编码
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 归属于bd的海图客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 官网uid
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
