using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowParentaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowParentaccountQueryModel : AopObject
    {
        /// <summary>
        /// 账户卡号
        /// </summary>
        [XmlElement("account_card_no")]
        public string AccountCardNo { get; set; }

        /// <summary>
        /// 物流公司编码，由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

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
        /// 网商解决方案CODE,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_scene_code")]
        public string MybankSceneCode { get; set; }
    }
}
