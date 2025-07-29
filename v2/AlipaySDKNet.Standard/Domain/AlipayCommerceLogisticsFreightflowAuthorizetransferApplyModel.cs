using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAuthorizetransferApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowAuthorizetransferApplyModel : AopObject
    {
        /// <summary>
        /// 委托授权合约号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 转账金额，单位分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务幂等号,格式标准：需要在尾部添加时间戳，格式为yyyyMMdd。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种编码（如CNY）
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 备注（可填写订单描述信息）
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 银行管理模式。 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 网商银行解决方案CODE,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_scene_code")]
        public string MybankSceneCode { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_participant")]
        public FreightFlowParticipantInfo PayeeParticipant { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_participant")]
        public FreightFlowParticipantInfo PayerParticipant { get; set; }

        /// <summary>
        /// 交易请求时间 标准格式：yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
