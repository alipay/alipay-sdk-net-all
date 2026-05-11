using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServicePackageItem Data Structure.
    /// </summary>
    [Serializable]
    public class ServicePackageItem : AopObject
    {
        /// <summary>
        /// 权益ID（商品ID或折扣权益ID）
        /// </summary>
        [XmlElement("rights_id")]
        public string RightsId { get; set; }

        /// <summary>
        /// 服务项名称
        /// </summary>
        [XmlElement("rights_name")]
        public string RightsName { get; set; }

        /// <summary>
        /// 权益类型： 1-商品权益 2-折扣权益 3-渠道价权益
        /// </summary>
        [XmlElement("rights_type")]
        public long RightsType { get; set; }

        /// <summary>
        /// 规格数量，单位：次
        /// </summary>
        [XmlElement("spec_quantity")]
        public long SpecQuantity { get; set; }

        /// <summary>
        /// 剩余规格数量，单位：次
        /// </summary>
        [XmlElement("spec_quantity_left")]
        public long SpecQuantityLeft { get; set; }

        /// <summary>
        /// 规格类型： 1-固定次数 2-无限次
        /// </summary>
        [XmlElement("spec_type")]
        public long SpecType { get; set; }
    }
}
