using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflinePaysaasOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflinePaysaasOrderCancelModel : AopObject
    {
        /// <summary>
        /// 收款订单投送N手持设备ID
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 服务商外部单号,外部实际使用单号
        /// </summary>
        [XmlElement("isv_out_order_no")]
        public string IsvOutOrderNo { get; set; }

        /// <summary>
        /// 商家的直间连类型，按照商家类型，选择正确的枚举值。
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备供应商 ID：supplierId，如意生态版AMX设备请填写“201901111100635561”
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
