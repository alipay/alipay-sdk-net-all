using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatepriceSetResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardTemplatepriceSetResponse : AopResponse
    {
        /// <summary>
        /// 已处理的商品模板ID。
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 本次成功设置或删除的价格明细数量。
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
