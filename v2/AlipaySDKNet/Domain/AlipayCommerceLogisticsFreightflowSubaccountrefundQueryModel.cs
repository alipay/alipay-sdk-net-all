using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountrefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowSubaccountrefundQueryModel : AopObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 唯一性区分，业务幂等号；若需要多次退款或明确退款失败后重试请更换此字段值，其他情况请原单重试
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 运企付在到账通知时通知给商户消息中的sub_trans_no
        /// </summary>
        [XmlElement("trans_no")]
        public string TransNo { get; set; }
    }
}
