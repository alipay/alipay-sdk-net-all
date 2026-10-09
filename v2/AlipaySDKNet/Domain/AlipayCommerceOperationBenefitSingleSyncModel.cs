using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBenefitSingleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBenefitSingleSyncModel : AopObject
    {
        /// <summary>
        /// 权益行为，CREATE-创建，MODIFY-修改，DELETE-删除
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 支付宝内券活动对象
        /// </summary>
        [XmlElement("activity_benefit")]
        public ActivityBenefit ActivityBenefit { get; set; }

        /// <summary>
        /// 会员权益
        /// </summary>
        [XmlElement("privilege_benefit")]
        public PrivilegeBenefit PrivilegeBenefit { get; set; }

        /// <summary>
        /// 卡包卡模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
