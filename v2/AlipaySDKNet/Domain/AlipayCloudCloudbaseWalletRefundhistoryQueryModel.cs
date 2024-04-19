using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRefundhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletRefundhistoryQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 提现日期
        /// </summary>
        [XmlElement("refund_date")]
        public string RefundDate { get; set; }
    }
}
