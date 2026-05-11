using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHealthmanagemDoctorSettleModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHealthmanagemDoctorSettleModel : AopObject
    {
        /// <summary>
        /// 医生核算的金额，精确到分，仅支持人民币
        /// </summary>
        [XmlElement("bill_amount")]
        public long BillAmount { get; set; }

        /// <summary>
        /// 服务项结算明细单的编号，由健管履约服务项结算时传递
        /// </summary>
        [XmlElement("finance_detail_no")]
        public string FinanceDetailNo { get; set; }

        /// <summary>
        /// 医生核算的时间
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 服务包中服务项配置的ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 服务项履约单号，由健管履约订单系统传递
        /// </summary>
        [XmlElement("item_order_no")]
        public string ItemOrderNo { get; set; }

        /// <summary>
        /// 服务包订单的单号，由健管履约订单系统传递
        /// </summary>
        [XmlElement("package_order_no")]
        public string PackageOrderNo { get; set; }
    }
}
