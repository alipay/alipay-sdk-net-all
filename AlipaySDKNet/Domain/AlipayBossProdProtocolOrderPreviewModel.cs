using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdProtocolOrderPreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdProtocolOrderPreviewModel : AopObject
    {
        /// <summary>
        /// 签约账号
        /// </summary>
        [XmlArray("card_nos")]
        [XmlArrayItem("string")]
        public List<string> CardNos { get; set; }

        /// <summary>
        /// 商户联系人信息
        /// </summary>
        [XmlElement("contact_info")]
        public ContactInfomation ContactInfo { get; set; }

        /// <summary>
        /// 是否需要包含个性化价格协议
        /// </summary>
        [XmlElement("include_custom_protocol")]
        public bool IncludeCustomProtocol { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant_info")]
        public MerchantInformation MerchantInfo { get; set; }

        /// <summary>
        /// 是否需要文件
        /// </summary>
        [XmlElement("need_file")]
        public bool NeedFile { get; set; }

        /// <summary>
        /// 是否需要填充协议模板动态内容（如需要，签约账号，商户信息，联系人信息需要传递）
        /// </summary>
        [XmlElement("need_fill_item")]
        public bool NeedFillItem { get; set; }

        /// <summary>
        /// 是否返回html
        /// </summary>
        [XmlElement("need_html")]
        public bool NeedHtml { get; set; }

        /// <summary>
        /// 销售方案
        /// </summary>
        [XmlElement("sale_plans")]
        public SalePlanInfo SalePlans { get; set; }

        /// <summary>
        /// 系统来源，不填默认为主站
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
