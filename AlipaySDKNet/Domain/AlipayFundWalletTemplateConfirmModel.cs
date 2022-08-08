using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletTemplateConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletTemplateConfirmModel : AopObject
    {
        /// <summary>
        /// 开户场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 钱包场景码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
