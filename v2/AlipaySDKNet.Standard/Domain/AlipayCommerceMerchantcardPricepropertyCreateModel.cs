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
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 每期价格
        /// </summary>
        [XmlArray("period_price_list")]
        [XmlArrayItem("card_period_price")]
        public List<CardPeriodPrice> PeriodPriceList { get; set; }
    }
}
