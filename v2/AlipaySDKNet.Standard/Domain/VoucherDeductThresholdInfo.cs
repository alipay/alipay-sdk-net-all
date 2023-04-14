using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherDeductThresholdInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDeductThresholdInfo : AopObject
    {
        /// <summary>
        /// 自定义门槛描述
        /// </summary>
        [XmlElement("customer_define_voucher_threshold_desc")]
        public string CustomerDefineVoucherThresholdDesc { get; set; }

        /// <summary>
        /// 邮费信息
        /// </summary>
        [XmlElement("voucher_express_info")]
        public VoucherExpressInfo VoucherExpressInfo { get; set; }

        /// <summary>
        /// 商品规格信息，数量，尺寸，大小等
        /// </summary>
        [XmlElement("voucher_goods_quantity_specification_info")]
        public VoucherGoodsQuantitySpecificationInfo VoucherGoodsQuantitySpecificationInfo { get; set; }
    }
}
