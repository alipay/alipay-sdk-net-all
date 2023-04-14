using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceZhimaPreorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceZhimaPreorderCreateModel : AopObject
    {
        /// <summary>
        /// alipay_store_id
        /// </summary>
        [XmlElement("alipay_store_id")]
        public string AlipayStoreId { get; set; }

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
        /// ISV商户ID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 开放平台appId
        /// </summary>
        [XmlElement("openapi_app_id")]
        public string OpenapiAppId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// storeId
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 外部任务模版id，如芝麻GO活动模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 外部模版类型
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }

        /// <summary>
        /// 超时关单时间 默认1H。1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m 签约超时关单时间依赖这个时间
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
