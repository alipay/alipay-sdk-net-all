using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCardDepositConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCardDepositConsultModel : AopObject
    {
        /// <summary>
        /// 场景码，DEPOSIT_CERT：充值凭证
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 指定卡号咨询
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
