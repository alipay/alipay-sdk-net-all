using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletFundhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletFundhistoryQueryModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 充值日期
        /// </summary>
        [XmlElement("fund_date")]
        public string FundDate { get; set; }
    }
}
