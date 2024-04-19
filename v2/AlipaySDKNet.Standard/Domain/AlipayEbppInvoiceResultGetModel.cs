using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceResultGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceResultGetModel : AopObject
    {
        /// <summary>
        /// 开票申请id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 业务平台对应的订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        [XmlElement("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户id
        /// </summary>
        [XmlElement("platform_user_id")]
        public string PlatformUserId { get; set; }
    }
}
