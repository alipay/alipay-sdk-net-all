using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MpcDeliveryInfo : AopObject
    {
        /// <summary>
        /// 显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 邮费
        /// </summary>
        [XmlElement("post_fee")]
        public long PostFee { get; set; }
    }
}
