using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowSubaccountQueryModel : AopObject
    {
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
        /// 网商银行解决方案COED,当mode=ANT_MYBANK时必选
        /// </summary>
        [XmlElement("mybank_scene_code")]
        public string MybankSceneCode { get; set; }

        /// <summary>
        /// 用于区分开户场景，映射解决方案实例配置。可与网商确认传入的必要性
        /// </summary>
        [XmlElement("mybank_scene_type")]
        public string MybankSceneType { get; set; }

        /// <summary>
        /// 用于区分开户子场景，映射解决方案实例配置。可与网商确认传入的必要性
        /// </summary>
        [XmlElement("mybank_sub_scene")]
        public string MybankSubScene { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("sub_bank_card_no")]
        public string SubBankCardNo { get; set; }
    }
}
