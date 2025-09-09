using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsRenewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseCouponsRenewQueryModel : AopObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 购买时长(月)
        /// </summary>
        [XmlElement("purchase_month")]
        public string PurchaseMonth { get; set; }
    }
}
