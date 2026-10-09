using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundEnterprisepayGroupDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundEnterprisepayGroupDeleteModel : AopObject
    {
        /// <summary>
        /// 企业签约账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 平台和企业的三方授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，联系支付宝分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码，默认值 ENTERPRISE_PAY
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
