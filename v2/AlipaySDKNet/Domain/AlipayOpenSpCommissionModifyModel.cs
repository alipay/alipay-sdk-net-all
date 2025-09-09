using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpCommissionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpCommissionModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_list")]
        [XmlArrayItem("commission_info")]
        public List<CommissionInfo> CommissionList { get; set; }

        /// <summary>
        /// 抽佣场景
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户登录账号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }
    }
}
