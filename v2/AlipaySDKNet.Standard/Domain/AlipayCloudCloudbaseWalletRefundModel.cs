using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletRefundModel : AopObject
    {
        /// <summary>
        /// 提现金额(分)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
