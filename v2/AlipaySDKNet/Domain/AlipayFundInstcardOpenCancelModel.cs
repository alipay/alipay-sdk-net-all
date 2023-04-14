using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundInstcardOpenCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundInstcardOpenCancelModel : AopObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 开户机构信息
        /// </summary>
        [XmlElement("inst_info")]
        public InstInfo InstInfo { get; set; }

        /// <summary>
        /// 商户支付宝收款账号
        /// </summary>
        [XmlElement("merchant_info")]
        public MerchantIdentityParams MerchantInfo { get; set; }

        /// <summary>
        /// 销售产品码。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
