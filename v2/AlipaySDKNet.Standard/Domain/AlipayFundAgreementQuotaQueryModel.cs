using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAgreementQuotaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAgreementQuotaQueryModel : AopObject
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlArray("agreement_no_list")]
        [XmlArrayItem("string")]
        public List<string> AgreementNoList { get; set; }

        /// <summary>
        /// 场景码，非固定值，使用的对应的资金场景码保持一致
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 额度产品码，非固定值，使用的对应的资金产品码保持一致
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
