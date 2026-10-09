using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoPreorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoPreorderCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务发生时间，如2016-07-06 00:00:02 签约超时关单时间依赖这个时间 这个时间会做幂等校验，如果创单幂等，但时间不同会失败
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 废弃字段，勿用
        /// </summary>
        [XmlElement("custom_temp_conf")]
        public string CustomTempConf { get; set; }

        /// <summary>
        /// 协议到期后通知
        /// </summary>
        [XmlElement("expire_aisle_data")]
        public string ExpireAisleData { get; set; }

        /// <summary>
        /// 动态配置参数
        /// </summary>
        [XmlElement("ext_template_conf")]
        public ExtTemplateConf ExtTemplateConf { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public PreOrderExtInfo ExtendParams { get; set; }

        /// <summary>
        /// 冻结金额，单位：元
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// ISV商户ID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 外部请求号，唯一
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户侧用户唯一标识。ex.商户侧uid
        /// </summary>
        [XmlElement("partner_user_identifier")]
        public string PartnerUserIdentifier { get; set; }

        /// <summary>
        /// 结算成功后通知
        /// </summary>
        [XmlElement("pay_aisle_data")]
        public string PayAisleData { get; set; }

        /// <summary>
        /// 签约成功后通知
        /// </summary>
        [XmlElement("sign_aisle_data")]
        public string SignAisleData { get; set; }

        /// <summary>
        /// 签约芝麻GO的模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 超时关单时间 默认1H。1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m 签约超时关单时间依赖这个时间
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
