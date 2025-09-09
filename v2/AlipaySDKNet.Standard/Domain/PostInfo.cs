using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PostInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PostInfo : AopObject
    {
        /// <summary>
        /// 客服电话
        /// </summary>
        [XmlElement("customer_service_phone")]
        public string CustomerServicePhone { get; set; }

        /// <summary>
        /// 收件地址
        /// </summary>
        [XmlElement("receiving_address")]
        public string ReceivingAddress { get; set; }

        /// <summary>
        /// 收件单位
        /// </summary>
        [XmlElement("receiving_unit")]
        public string ReceivingUnit { get; set; }

        /// <summary>
        /// 补充资料信息，不包含额外扩展信息
        /// </summary>
        [XmlElement("supplementary_data_info")]
        public string SupplementaryDataInfo { get; set; }
    }
}
