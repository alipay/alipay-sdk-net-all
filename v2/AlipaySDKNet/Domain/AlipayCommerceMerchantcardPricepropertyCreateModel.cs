using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardPricepropertyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardPricepropertyCreateModel : AopObject
    {
        /// <summary>
        /// 周期卡计费信息，周期卡一客一价需要修改扣款方式可传该字段，非周期卡不传
        /// </summary>
        [XmlElement("card_property_cycle")]
        public CardPropertyCycle CardPropertyCycle { get; set; }

        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 卡类型，当不传card_template_id且传入card_type时，会取商户的默认卡ID
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 是否立即扣款，如果传入为true，则下单时则立即扣款。否则不立即扣款。
        /// </summary>
        [XmlElement("charge_now")]
        public bool ChargeNow { get; set; }

        /// <summary>
        /// 原价，单位：分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 每期价格
        /// </summary>
        [XmlArray("period_price_list")]
        [XmlArrayItem("card_period_price")]
        public List<CardPeriodPrice> PeriodPriceList { get; set; }

        /// <summary>
        /// 售卖价格，单位：分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
