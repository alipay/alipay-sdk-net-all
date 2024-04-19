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
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 钱包名称
        /// </summary>
        [XmlElement("wallet_template_name")]
        public string WalletTemplateName { get; set; }
    }
}
