using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 钱包场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 钱包产品code一般为FUND_TRUSTSHIP
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 钱包名称
        /// </summary>
        [XmlElement("wallet_template_name")]
        public string WalletTemplateName { get; set; }
    }
}
