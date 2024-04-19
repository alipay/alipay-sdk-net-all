using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanpayAssetConsultResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanpayAssetConsultResponse : AopResponse
    {
        /// <summary>
        /// 资产
        /// </summary>
        [XmlElement("asset_result")]
        public LoanPayAssetResult AssetResult { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public Refuse RefuseMsg { get; set; }

        /// <summary>
        /// 是否处理成功，true(成功)，false(失败)。true表示咨询成功，但不代表可见可用
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
