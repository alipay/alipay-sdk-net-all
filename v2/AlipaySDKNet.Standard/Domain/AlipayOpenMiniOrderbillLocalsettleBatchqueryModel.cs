using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderbillLocalsettleBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderbillLocalsettleBatchqueryModel : AopObject
    {
        /// <summary>
        /// 页大小，最大值为10，单位：条目数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页标识，第一页不传，第二页开始传入上一页返回的page_token
        /// </summary>
        [XmlElement("page_token")]
        public string PageToken { get; set; }

        /// <summary>
        /// 小程序订单结算日期，格式为"yyyy-MM-dd"，如"2023-03-22"
        /// </summary>
        [XmlElement("settlement_date")]
        public string SettlementDate { get; set; }
    }
}
