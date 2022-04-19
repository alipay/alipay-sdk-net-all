using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIdentitypayMemberSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIdentitypayMemberSignModel : AopObject
    {
        /// <summary>
        /// 物业审核
        /// </summary>
        [XmlElement("authentication_type")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// 签约场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 成员昵称
        /// </summary>
        [XmlElement("member_name")]
        public string MemberName { get; set; }

        /// <summary>
        /// 外部成员id(全局唯一)
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 外部组织id(全局唯一)
        /// </summary>
        [XmlElement("out_org_id")]
        public string OutOrgId { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
