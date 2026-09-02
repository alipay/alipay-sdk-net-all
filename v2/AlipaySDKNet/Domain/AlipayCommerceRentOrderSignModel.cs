using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentOrderSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentOrderSignModel : AopObject
    {
        /// <summary>
        /// 芝麻信用拓展信息
        /// </summary>
        [XmlElement("credit_ext_info")]
        public RentCreditExtInfoDTO CreditExtInfo { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；买家实名信息。 传入后支付宝会比对买家在支付宝端的实名信息。包含如下可选key： 1.identity_hash，买家姓名拼接身份证号后，使用SHA256摘要方式与UTF8编码后的hash值，返回的十六进制字符串，例如 “张三4566498798498498498498”对应的identity_hash应为“acc2b92ffc5ed9b472faa19748f10045c30434132784f774b00216a56b8841c6”
        /// </summary>
        [XmlElement("identity_params")]
        public string IdentityParams { get; set; }

        /// <summary>
        /// 是否需要人脸核身 true ：（默认）需要人脸核身 false：无需人脸核身
        /// </summary>
        [XmlElement("need_face_validate_flag")]
        public bool NeedFaceValidateFlag { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 租赁订单支付及信用产品签约信息
        /// </summary>
        [XmlElement("rent_sign_info")]
        public RentDoSignInfoDTO RentSignInfo { get; set; }
    }
}
