using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSharecodeHbfqCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSharecodeHbfqCreateModel : AopObject
    {
        /// <summary>
        /// 用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 跳转业务链接，例如ISV服务商的支付页面
        /// </summary>
        [XmlElement("biz_link")]
        public string BizLink { get; set; }

        /// <summary>
        /// 业务场景 例如：ISV_PAY：ISV的支付场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 扩展内容，主要满足花呗分期相关的额鉴权验等功能
        /// </summary>
        [XmlElement("ext_info")]
        public FQExtendParams ExtInfo { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 需要支付的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝商家ID，即商家账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。。
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 业务来源，业务接入的约定标识，代表业务的调用方。例如：ISV公司名称缩写
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 支付宝二级商户编号。 直付通模式和机构间连模式下必传，其它场景下不需要传入。
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 吱口令的有效期，例如：3600*24（代表一天）
        /// </summary>
        [XmlElement("time_out")]
        public long TimeOut { get; set; }
    }
}
