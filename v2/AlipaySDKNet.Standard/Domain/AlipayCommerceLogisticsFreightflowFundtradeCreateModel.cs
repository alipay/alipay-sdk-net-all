using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowFundtradeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowFundtradeCreateModel : AopObject
    {
        /// <summary>
        /// 商户需要保证业务流水号的唯一性，运企付内部通过业务流水号进行幂等处理
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 可填写网点信息+具体的动作
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 币种,人民币为CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 与运企付约定的物流公司编码
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 备注（可填写订单描述信息）
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 银行管理模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 网商银行应用id,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_app_id")]
        public string MybankAppId { get; set; }

        /// <summary>
        /// 网商银行分配的合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 关单时间2024-06-18 15:12:36
        /// </summary>
        [XmlElement("pay_expire_time")]
        public string PayExpireTime { get; set; }

        /// <summary>
        /// 收款方户名
        /// </summary>
        [XmlElement("payee_card_name")]
        public string PayeeCardName { get; set; }

        /// <summary>
        /// 收款方卡号
        /// </summary>
        [XmlElement("payee_id")]
        public string PayeeId { get; set; }

        /// <summary>
        /// 订单总金额,单位:分
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
