using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MarketingProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingProductInfo : AopObject
    {
        /// <summary>
        /// 预估金额（固定值）单位为元
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 预估最大金额（区间值）单位为元，与assess_amount互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最大金额（如衣物统收预估估价为区间2.5元-5元）。
        /// </summary>
        [XmlElement("assess_max_amount")]
        public string AssessMaxAmount { get; set; }

        /// <summary>
        /// 预估最大数量（区间值）单位为个、KG或G。与assess_quantity互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最大数量（如衣物统收预估重量为区间5KG-10KG）。
        /// </summary>
        [XmlElement("assess_max_quantity")]
        public string AssessMaxQuantity { get; set; }

        /// <summary>
        /// 预估最小金额（区间值）单位为元，与assess_amount互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最小金额（如衣物统收预估估价为区间2.5元-5元）。
        /// </summary>
        [XmlElement("assess_min_amount")]
        public string AssessMinAmount { get; set; }

        /// <summary>
        /// 预估最小数量（区间值）单位为个、KG或G，与assess_quantity互斥。当估价类型assess_type=RANGE_UNIT区间重量时，此时有最小数量（如衣物统收预估重量为区间5KG-10KG）。
        /// </summary>
        [XmlElement("assess_min_quantity")]
        public string AssessMinQuantity { get; set; }

        /// <summary>
        /// 预估数量（固定值）单位为个、KG或G，支持两位小数点。
        /// </summary>
        [XmlElement("assess_quantity")]
        public string AssessQuantity { get; set; }

        /// <summary>
        /// 回收商品估价类型
        /// </summary>
        [XmlElement("assess_type")]
        public string AssessType { get; set; }

        /// <summary>
        /// 质检金额（单位为元）
        /// </summary>
        [XmlElement("inspect_amount")]
        public string InspectAmount { get; set; }

        /// <summary>
        /// 质检数量,回收商完成商品质检后的数量。单位为个、KG或G。
        /// </summary>
        [XmlElement("inspect_quantity")]
        public string InspectQuantity { get; set; }

        /// <summary>
        /// 回收商品单位
        /// </summary>
        [XmlElement("unit_type")]
        public string UnitType { get; set; }
    }
}
