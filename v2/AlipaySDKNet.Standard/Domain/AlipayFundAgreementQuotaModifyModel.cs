using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAgreementQuotaModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAgreementQuotaModifyModel : AopObject
    {
        /// <summary>
        /// 协议额度设置信息
        /// </summary>
        [XmlArray("agreement_quota_modify_list")]
        [XmlArrayItem("agreement_quota_modify_list")]
        public List<AgreementQuotaModifyList> AgreementQuotaModifyList { get; set; }

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
