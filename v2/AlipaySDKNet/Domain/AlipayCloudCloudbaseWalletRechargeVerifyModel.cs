using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRechargeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletRechargeVerifyModel : AopObject
    {
        /// <summary>
        /// 小程序AppID
        /// </summary>
        [XmlElement("recharge_app_id")]
        public string RechargeAppId { get; set; }
    }
}
