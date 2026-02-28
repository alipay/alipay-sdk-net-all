using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowSubaccountCreateModel : AopObject
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
        /// 网商银行解决方案CODE,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_scene_code")]
        public string MybankSceneCode { get; set; }

        /// <summary>
        /// 网商场景.当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_scene_type")]
        public string MybankSceneType { get; set; }

        /// <summary>
        /// 网商子场景,当mode为ANT_MYBANK时由网商提供给商户
        /// </summary>
        [XmlElement("mybank_sub_scene")]
        public string MybankSubScene { get; set; }

        /// <summary>
        /// 唯一性区分
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务方自己的用户标识（类似于网商2266，主站相关的一般用支付宝2088开头的id）不要有中文
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 网点名称
        /// </summary>
        [XmlElement("out_user_name")]
        public string OutUserName { get; set; }

        /// <summary>
        /// 母户信息
        /// </summary>
        [XmlElement("parent_info")]
        public FreigtFlowAccount ParentInfo { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配。 如果mode为浦发银行，则为浦发APP对应的X-SPDB-Client-ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 浦发银行特定场景参数,当mode=SPDB时必选
        /// </summary>
        [XmlElement("spdb_spec_params")]
        public FreightFlowSpdbSpecParams SpdbSpecParams { get; set; }

        /// <summary>
        /// mode为网商银行时,且物流商为网货平台时,需要传入子户归属人
        /// </summary>
        [XmlElement("sub_account_owner_info")]
        public FreightFlowSubAccountOwnerInfo SubAccountOwnerInfo { get; set; }
    }
}
