using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpBusinessIndicatorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpBusinessIndicatorQueryModel : AopObject
    {
        /// <summary>
        /// 授权编号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 业务关键词
        /// </summary>
        [XmlElement("business_key")]
        public string BusinessKey { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
