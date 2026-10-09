using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarFeeItem Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarFeeItem : AopObject
    {
        /// <summary>
        /// 费用金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 费用描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 费用名称。租金、车行服务费等标准费用不需要此字段，字词段用于一些商户自定义的非标准费用
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 保障服务费用或增值服务费用必传此字段
        /// </summary>
        [XmlElement("unique_code")]
        public string UniqueCode { get; set; }
    }
}
