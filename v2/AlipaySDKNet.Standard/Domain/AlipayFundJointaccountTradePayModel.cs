using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountTradePayModel : AopObject
    {
        /// <summary>
        /// 企业账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 跳端扩展参数： [assignJointAccountId-指定企业码id] [pdSubBizScene-场景标识] [sourcePlatformInfo-平台扩展参数（outSource必传，其他可自定义）]
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否隐藏付款码页面相关功能性操作按钮
        /// </summary>
        [XmlElement("hide_menu")]
        public string HideMenu { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 支付方式： scan-正扫 qrcode-反扫
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
