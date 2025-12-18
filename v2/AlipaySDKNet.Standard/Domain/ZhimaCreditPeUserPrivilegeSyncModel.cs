using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserPrivilegeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeUserPrivilegeSyncModel : AopObject
    {
        /// <summary>
        /// 扩展参数，传入商户特质信息
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 芝麻特权活动唯一标识
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务流水号，通常为商户业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 特权状态，商户接入产品分配
        /// </summary>
        [XmlElement("privilege_status")]
        public string PrivilegeStatus { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
