using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypayModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppPaysharingprodFamilypayModifyModel : AopObject
    {
        /// <summary>
        /// 亲情卡卡唯一id,可通过查询接口响应参数获取
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 亲情卡功能管理，包含状态修改，功能修改
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 亲情卡额度信息，额度修改操作必传
        /// </summary>
        [XmlElement("quota_info")]
        public FamilyPayQuotaInfo QuotaInfo { get; set; }

        /// <summary>
        /// 当前操作人在亲情卡产品的角色
        /// </summary>
        [XmlElement("self_role")]
        public string SelfRole { get; set; }

        /// <summary>
        /// 支付宝亲情卡业务定义给外部平台唯一业务身份标识，接入值咨询@子矛
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 当前操作人用户信息
        /// </summary>
        [XmlElement("user_info")]
        public FamilyPayBizUserInfo UserInfo { get; set; }
    }
}
