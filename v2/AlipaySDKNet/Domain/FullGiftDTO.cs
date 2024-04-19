using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FullGiftDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FullGiftDTO : AopObject
    {
        /// <summary>
        /// 赠送金额，如果有阶梯规则，多个值用英文逗号分割，例如：10,20
        /// </summary>
        [XmlElement("gift_amount")]
        public string GiftAmount { get; set; }

        /// <summary>
        /// 赠送最低消费，如果有阶梯规则，多个值用英文逗号分割，例如：10,20
        /// </summary>
        [XmlElement("gift_min_consumption")]
        public string GiftMinConsumption { get; set; }

        /// <summary>
        /// 赠送份数，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [XmlElement("gift_nums")]
        public string GiftNums { get; set; }

        /// <summary>
        /// 满赠skuid
        /// </summary>
        [XmlArray("gift_sku_id")]
        [XmlArrayItem("string")]
        public List<string> GiftSkuId { get; set; }

        /// <summary>
        /// 最低消费，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [XmlElement("min_consumption")]
        public string MinConsumption { get; set; }

        /// <summary>
        /// 最少份数，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [XmlElement("min_nums")]
        public string MinNums { get; set; }

        /// <summary>
        /// 营销skuId
        /// </summary>
        [XmlArray("promotion_sku_id")]
        [XmlArrayItem("string")]
        public List<string> PromotionSkuId { get; set; }
    }
}
