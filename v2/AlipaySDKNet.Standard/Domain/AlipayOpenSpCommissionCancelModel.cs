using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpCommissionCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpCommissionCancelModel : AopObject
    {
        /// <summary>
        /// 动作 CANCEL,TERMINAL
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_list")]
        [XmlArrayItem("cancel_commission_info")]
        public List<CancelCommissionInfo> CommissionList { get; set; }

        /// <summary>
        /// 抽佣场景
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 整体撤销/停止或部分撤销停止，整体不需要传commission_list
        /// </summary>
        [XmlElement("handle_type")]
        public string HandleType { get; set; }

        /// <summary>
        /// 商户 id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }
    }
}
