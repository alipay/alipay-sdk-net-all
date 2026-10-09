using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品咨询营销的金额
        /// </summary>
        [XmlElement("biz_amount")]
        public MultiCurrencyMoneyDTO BizAmount { get; set; }

        /// <summary>
        /// 扩展参数（商户 pid、国家区域等），填写json字符串即可
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 咨询营销时唯一商品ID
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
