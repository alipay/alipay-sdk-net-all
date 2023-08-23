using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceiveInfoDto Data Structure.
    /// </summary>
    [Serializable]
    public class ReceiveInfoDto : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [XmlElement("receive")]
        public string Receive { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("telephone")]
        public string Telephone { get; set; }
    }
}
