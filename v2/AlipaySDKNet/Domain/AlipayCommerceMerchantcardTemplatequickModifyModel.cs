using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatequickModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplatequickModifyModel : AopObject
    {
        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 线上售卖开关，可选。传入01表示将卡推广至线上售卖。传入02标识关闭线上售卖。
        /// </summary>
        [XmlElement("online_sale_switch")]
        public string OnlineSaleSwitch { get; set; }

        /// <summary>
        /// 售卖信息
        /// </summary>
        [XmlElement("sale_info")]
        public CardTemplateSale SaleInfo { get; set; }

        /// <summary>
        /// 新的库存数量，单位个
        /// </summary>
        [XmlElement("saleable_count")]
        public long SaleableCount { get; set; }
    }
}
