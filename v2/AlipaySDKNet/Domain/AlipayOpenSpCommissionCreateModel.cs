using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpCommissionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpCommissionCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_info_list")]
        [XmlArrayItem("scene_commission_info")]
        public List<SceneCommissionInfo> CommissionInfoList { get; set; }

        /// <summary>
        /// 商家 id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        [XmlElement("merchant_logon_id")]
        public string MerchantLogonId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }
    }
}
