using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OperationAddress Data Structure.
    /// </summary>
    [Serializable]
    public class OperationAddress : AopObject
    {
        /// <summary>
        /// 营业地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国籍
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
