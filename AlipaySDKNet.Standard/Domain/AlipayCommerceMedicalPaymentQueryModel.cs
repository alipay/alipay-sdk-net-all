using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalPaymentQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道订单流水号,取值为调用下单接口中返回的渠道渠道订单号流水号字段
        /// </summary>
        [XmlElement("chnl_order_sn")]
        public string ChnlOrderSn { get; set; }

        /// <summary>
        /// 医院订单号(商户需保证appId维度唯一)
        /// </summary>
        [XmlElement("med_org_ord")]
        public string MedOrgOrd { get; set; }

        /// <summary>
        /// 支付宝用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 医保电子凭证线上身份核验服务反馈单中的定点医疗机构编码
        /// </summary>
        [XmlElement("org_no")]
        public string OrgNo { get; set; }

        /// <summary>
        /// 外部订单类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 第三方平台商单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付订单号（处方上传的出参订单号）
        /// </summary>
        [XmlElement("pay_order_id")]
        public string PayOrderId { get; set; }

        /// <summary>
        /// 支付宝侧自费交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
