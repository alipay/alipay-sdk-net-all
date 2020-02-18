using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAlipaypointSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAlipaypointSendModel : AopObject
    {
        /// <summary>
        /// 签约商户的集分宝的预算库，扣除此预算库的集分宝发放给用户。会校验budgetcode和业务方appId的签约商户pid的关联关系，若无关则发放失败。
        /// </summary>
        [XmlElement("budget_code")]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 商户关于该笔发放的描述或者信息补充，仅存储，无实际校验功能
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商家发放集分宝所产生的业务号，集分宝服务将依据此字段，以及其他相关字段来进行幂等控制，需要慎重传递，否则可能会造成损失
        /// </summary>
        [XmlElement("partner_biz_no")]
        public string PartnerBizNo { get; set; }

        /// <summary>
        /// 发放给用户的集分宝个数
        /// </summary>
        [XmlElement("point_amount")]
        public long PointAmount { get; set; }

        /// <summary>
        /// 被发放集分宝用户的支付宝登录号，邮箱地址或者手机号均可，与user_id字段二选一，在有user_id时，优先使用user_id字段
        /// </summary>
        [XmlElement("user_account")]
        public string UserAccount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，与user_account字段二选一，本字段非空时，优先使用本字段
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
