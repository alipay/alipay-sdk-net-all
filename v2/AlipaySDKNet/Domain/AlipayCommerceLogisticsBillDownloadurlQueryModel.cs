using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsBillDownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsBillDownloadurlQueryModel : AopObject
    {
        /// <summary>
        /// * 日账单格式为yyyy-MM-dd，最早可下载近6年的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。 * 当这一日非账单出账日 会返回空
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// ORDER_SETTLE：订单结算单账单
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 支付宝分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 物流账单场景编码，由支付宝定义
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
