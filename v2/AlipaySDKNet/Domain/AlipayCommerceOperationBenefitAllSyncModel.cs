using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBenefitAllSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBenefitAllSyncModel : AopObject
    {
        /// <summary>
        /// 内券活动列表，最多可填写0-20个券活动
        /// </summary>
        [XmlArray("activity_benefit_list")]
        [XmlArrayItem("activity_benefit")]
        public List<ActivityBenefit> ActivityBenefitList { get; set; }

        /// <summary>
        /// 会员权益列表，需要指定3-20个会员权益
        /// </summary>
        [XmlArray("privilege_benefit_list")]
        [XmlArrayItem("privilege_benefit")]
        public List<PrivilegeBenefit> PrivilegeBenefitList { get; set; }

        /// <summary>
        /// 卡包卡模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
