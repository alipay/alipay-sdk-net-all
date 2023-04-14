using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoSignApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPeZmgoSignApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝的用户id。用于水平校验，当传入用户id与实际唤起支付宝用户id不一致时，签约申请失败。特殊业务(用户在商户侧已经绑定了支付宝A，不允许支付宝B进行开通芝麻GO)需求定制，无特殊需求时不要传入此参数
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝的用户id。用于水平校验，当传入用户id与实际唤起支付宝用户id不一致时，签约申请失败。特殊业务(用户在商户侧已经绑定了支付宝A，不允许支付宝B进行开通芝麻GO)需求定制，无特殊需求时不要传入此参数
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 外部渠道标识
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public SignExtendInfo ExtendParams { get; set; }

        /// <summary>
        /// 自定义冻结金额，单位：元。部分商户开放，需要申请
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 芝麻GO预创单号
        /// </summary>
        [XmlElement("preorder_no")]
        public string PreorderNo { get; set; }

        /// <summary>
        /// 模版ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚完成时间，逾期支付宝将关闭。取值范围：1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m。 默认为1h
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
