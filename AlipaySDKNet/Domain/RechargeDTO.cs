using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RechargeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeDTO : AopObject
    {
        /// <summary>
        /// 赠送金额，如果有阶梯规则，多个值用英文逗号分割，例如：10,20
        /// </summary>
        [XmlElement("gift_amount")]
        public string GiftAmount { get; set; }

        /// <summary>
        /// 赠送份数，如果有阶梯规则，多个值用英文逗号分割，例如：1,2
        /// </summary>
        [XmlElement("gift_nums")]
        public string GiftNums { get; set; }

        /// <summary>
        /// 赠送商品sku_id
        /// </summary>
        [XmlArray("gift_sku_id")]
        [XmlArrayItem("string")]
        public List<string> GiftSkuId { get; set; }

        /// <summary>
        /// 充值金额，必须是数字格式，支持两位小数。 如果有阶梯规则，多个值用英文逗号分割，例如：10,200
        /// </summary>
        [XmlElement("recharge_amount")]
        public string RechargeAmount { get; set; }
    }
}
