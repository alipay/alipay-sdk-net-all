using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowCloudfundrefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowCloudfundrefundQueryModel : AopObject
    {
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
        /// 如果mode为网商银行代表网商银行分配的合作方机构号
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 发起退款申请时的业务流水号
        /// </summary>
        [XmlElement("refund_biz_no")]
        public string RefundBizNo { get; set; }
    }
}
