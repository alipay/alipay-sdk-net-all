using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitPlanlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitPlanlistQueryModel : AopObject
    {
        /// <summary>
        /// 查询可报名方案的目标商户信息。  说明： 如果该复杂对象不填。则默认为是查询调用者本人。 如果填写，则认为是查询该商户。  建议:服务商身份接入时必传，否则可报名方案不是针对代运营商户的。
        /// </summary>
        [XmlElement("enroll_merchant")]
        public RecruitEnrollMerchant EnrollMerchant { get; set; }

        /// <summary>
        /// 第几页，默认1（需要在1和999之间）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20，需要在1和100之间
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
