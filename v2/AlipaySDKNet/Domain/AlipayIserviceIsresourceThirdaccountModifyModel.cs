using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceThirdaccountModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceThirdaccountModifyModel : AopObject
    {
        /// <summary>
        /// 扩展信息，JSON字符串，覆盖更新
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 企业用户账号
        /// </summary>
        [XmlElement("external_acc_id")]
        public string ExternalAccId { get; set; }

        /// <summary>
        /// 状态：ACTIVE-激活，IFREEZE-冻结
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 星云用户ID
        /// </summary>
        [XmlElement("verify_user_id")]
        public string VerifyUserId { get; set; }

        /// <summary>
        /// 工作台
        /// </summary>
        [XmlElement("workstation")]
        public string Workstation { get; set; }
    }
}
