using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商品归属appid
        /// </summary>
        [XmlElement("card_template_appid")]
        public string CardTemplateAppid { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
