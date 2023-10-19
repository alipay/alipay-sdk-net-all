using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateUseResult Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateUseResult : AopObject
    {
        /// <summary>
        /// 凭证实例的金额信息，在异常场景下可能为空，需要判断是否有值才可进行使用。
        /// </summary>
        [XmlElement("amount_info")]
        public CertificateInstanceAmountInfo AmountInfo { get; set; }

        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 三方码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 核销准备返回的支付宝平台加密券码
        /// </summary>
        [XmlElement("encrypted_code")]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 购买商品的订单id。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商家侧核销对应的交易订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 核销结果枚举
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 本次核销的次序号信息
        /// </summary>
        [XmlElement("serial_info_list")]
        public CertificateSerialInfo SerialInfoList { get; set; }

        /// <summary>
        /// 核销操作单号,核销成功必填,撤销核销使用
        /// </summary>
        [XmlElement("use_order_no")]
        public string UseOrderNo { get; set; }
    }
}
