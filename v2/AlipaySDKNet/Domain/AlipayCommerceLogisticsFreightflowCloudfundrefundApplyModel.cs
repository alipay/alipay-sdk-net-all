using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowCloudfundrefundApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowCloudfundrefundApplyModel : AopObject
    {
        /// <summary>
        /// 退款业务流水号(根据业务流水号进行幂等处理)
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 收银台创单时的业务流水号
        /// </summary>
        [XmlElement("cloud_fund_biz_no")]
        public string CloudFundBizNo { get; set; }

        /// <summary>
        /// mode为网商银行时： 收银台创单完成后响应参数中的order_no参数值
        /// </summary>
        [XmlElement("cloud_fund_order_no")]
        public string CloudFundOrderNo { get; set; }

        /// <summary>
        /// 币种，必须同原交易
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 与运企付约定的物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行提供给商户的appId
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 退款付方id，即原支付单收方  如果是商户，则填入merchantId； 如果是平台，则填入isvOrgId； 如果是子户，则填入子户外标(子户号)
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 退款付方类型，即原支付单收方
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 如果mode为网商银行代表网商银行分配的合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 退款金额,单位：分
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }
    }
}
