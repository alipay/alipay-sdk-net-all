using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowAllocateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowAllocateApplyModel : AopObject
    {
        /// <summary>
        /// 调拨方向: SUB_TO_PARENT(子户调拨到母户), PARENT_TO_SUB(母户调拨到子户)
        /// </summary>
        [XmlElement("allocate_direction")]
        public string AllocateDirection { get; set; }

        /// <summary>
        /// amount 金额(单位：分)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商户需要保证业务流水号的唯一性，运企付内部通过业务流水号进行幂等处理
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 币种
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
        /// 模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商应用id,mode为ANT_MYBANK时必填
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 网商银行解决方案Code
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
        /// 交易请求时间 yyyyMMddHHmmss
        /// </summary>
        [XmlElement("request_time")]
        public string RequestTime { get; set; }
    }
}
