using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationMaterialVoucherBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationMaterialVoucherBindModel : AopObject
    {
        /// <summary>
        /// 外部业务号，用于幂等使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 扫描物料的码值
        /// </summary>
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
