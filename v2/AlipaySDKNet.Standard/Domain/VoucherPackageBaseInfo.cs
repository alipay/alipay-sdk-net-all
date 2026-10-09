using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherPackageBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherPackageBaseInfo : AopObject
    {
        /// <summary>
        /// 券包购买结束时间
        /// </summary>
        [XmlElement("purchase_end_time")]
        public string PurchaseEndTime { get; set; }

        /// <summary>
        /// 券包购买开始时间
        /// </summary>
        [XmlElement("purchase_start_time")]
        public string PurchaseStartTime { get; set; }

        /// <summary>
        /// 券包id
        /// </summary>
        [XmlElement("voucher_package_id")]
        public string VoucherPackageId { get; set; }

        /// <summary>
        /// 券包名称
        /// </summary>
        [XmlElement("voucher_package_name")]
        public string VoucherPackageName { get; set; }

        /// <summary>
        /// 券包状态
        /// </summary>
        [XmlElement("voucher_package_status")]
        public string VoucherPackageStatus { get; set; }

        /// <summary>
        /// 券包总价值（单位是元）： 券包下券的优惠总额（满减券指优惠面额，折扣券指优惠上限，特价券指原价减去特价）
        /// </summary>
        [XmlElement("voucher_total_amount")]
        public string VoucherTotalAmount { get; set; }
    }
}
