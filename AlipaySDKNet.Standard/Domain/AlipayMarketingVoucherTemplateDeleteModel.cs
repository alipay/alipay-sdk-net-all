using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherTemplateDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherTemplateDeleteModel : AopObject
    {
        /// <summary>
        /// 券模板 id，可通过<a href="https://opendocs.alipay.com/apis/api_5/alipay.marketing.voucher.templatelist.query">alipay.marketing.voucher.templatelist.query</a>(查询券模板列表)接口查询获取。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
