using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherGoodsQuantitySpecificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherGoodsQuantitySpecificationInfo : AopObject
    {
        /// <summary>
        /// 定向类型用于规格设置，比如：FIX 表示 固定满X件，APPOINT 表示指定第N件
        /// </summary>
        [XmlElement("directional_type")]
        public string DirectionalType { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("specification_quantity")]
        public long SpecificationQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("specification_unit")]
        public string SpecificationUnit { get; set; }
    }
}
