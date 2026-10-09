using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQrcodecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectBindQrcodecreateModel : AopObject
    {
        /// <summary>
        /// 动作类型，绑定bind/解除绑定un_bind
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 外部业务号。有商户扫码绑定或解除绑定时，操作成功后会发送消息，此业务号将在消息中原样返回
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
