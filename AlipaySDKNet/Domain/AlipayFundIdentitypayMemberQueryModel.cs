using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundIdentitypayMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundIdentitypayMemberQueryModel : AopObject
    {
        /// <summary>
        /// 查询签约信息场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 外部成员Id（全局唯一）
        /// </summary>
        [XmlElement("out_member_id")]
        public string OutMemberId { get; set; }

        /// <summary>
        /// 外部组织Id（全局唯一）
        /// </summary>
        [XmlElement("out_org_id")]
        public string OutOrgId { get; set; }

        /// <summary>
        /// 查询签约信息产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
