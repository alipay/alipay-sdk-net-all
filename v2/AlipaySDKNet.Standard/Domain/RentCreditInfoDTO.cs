using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCreditInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentCreditInfoDTO : AopObject
    {
        /// <summary>
        /// 芝麻外部类目 <a href="https://opendocs.alipay.com/open/10719" target="_blank">类目枚举文档</a>
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 芝麻信用服务ID
        /// </summary>
        [XmlElement("zm_service_id")]
        public string ZmServiceId { get; set; }
    }
}
