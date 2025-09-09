using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeFinancePrecreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeFinancePrecreateModel : AopObject
    {
        /// <summary>
        /// 卖家账户，本次需要和拓展中卖家信息里面的内容一致 alipayAccountType为userId时，传递16位的支付宝20088id； alipayAccountType为loginName时，传递支付宝登录号，如邮箱地址；
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 卖家账户类型 支付宝账号对应的支付宝唯一用户号: userId 支付宝登录号: loginName
        /// </summary>
        [XmlElement("alipay_account_type")]
        public string AlipayAccountType { get; set; }

        /// <summary>
        /// 订单金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务发生时间，格式参考示例值，不支持传递毫秒
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 用于传递特殊业务场景的拓展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部订单号，一般建议32位以内
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求号，由外部平台生成的全局唯一id，标识一笔请求
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
