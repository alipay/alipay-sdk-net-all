using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasTagSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasTagSaveModel : AopObject
    {
        /// <summary>
        /// 加油业务标签的key
        /// </summary>
        [XmlElement("tag_key")]
        public string TagKey { get; set; }

        /// <summary>
        /// 不同的tagKey传对应的value
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }

        /// <summary>
        /// 根据target_type传对应的id
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// PID：修改商户，SHOP_ID：修改门店
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
