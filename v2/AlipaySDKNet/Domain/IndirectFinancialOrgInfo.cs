using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectFinancialOrgInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectFinancialOrgInfo : AopObject
    {
        /// <summary>
        /// 金融机构许可证图片，最多五张（使用图片上传接口）
        /// </summary>
        [XmlArray("financial_org_cert_img")]
        [XmlArrayItem("string")]
        public List<string> FinancialOrgCertImg { get; set; }

        /// <summary>
        /// 银行业(BANK)、支付机构(PAYMENT)、保险业(INSURANCE)、交易及结算类金融机构(SETTLE)、OTHER(OTHER)
        /// </summary>
        [XmlElement("financial_org_type")]
        public string FinancialOrgType { get; set; }
    }
}
