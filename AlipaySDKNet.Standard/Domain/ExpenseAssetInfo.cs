using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseAssetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseAssetInfo : AopObject
    {
        /// <summary>
        /// 资产ID
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产归属员工的ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工OPENID
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 支付业务类型
        /// </summary>
        [XmlElement("pay_biz_type")]
        public string PayBizType { get; set; }

        /// <summary>
        /// 消耗资产的额度，单位分
        /// </summary>
        [XmlElement("peer_pay_amount")]
        public string PeerPayAmount { get; set; }

        /// <summary>
        /// 退款号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }
    }
}
