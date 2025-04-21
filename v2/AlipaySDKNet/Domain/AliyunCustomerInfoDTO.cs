using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliyunCustomerInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AliyunCustomerInfoDTO : AopObject
    {
        /// <summary>
        /// 客户CID信息
        /// </summary>
        [XmlElement("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 用于保存客户名称
        /// </summary>
        [XmlElement("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 用户ID信息
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
