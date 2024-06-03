using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneCommonPreOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCommonPreOrderModel : AopObject
    {
        /// <summary>
        /// 用户手动选中或默认选中了自动续保
        /// </summary>
        [XmlElement("auto_renewal")]
        public bool AutoRenewal { get; set; }

        /// <summary>
        /// 预下单扩展参数
        /// </summary>
        [XmlElement("biz_data")]
        public InsOpenPreOrderBizData BizData { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [XmlElement("holder_user")]
        public InsOpenUserDTO HolderUser { get; set; }

        /// <summary>
        /// 被保人
        /// </summary>
        [XmlElement("insured_user")]
        public InsOpenUserDTO InsuredUser { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 报价id
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 推荐流水id
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 客户端渠道:wx_applet/android/pc/ios/alipay_applet
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
