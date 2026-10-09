using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class OrderExtendParams : AopObject
    {
        /// <summary>
        /// 收银台结果页面回跳地址
        /// </summary>
        [XmlElement("cashier_result_render_url")]
        public string CashierResultRenderUrl { get; set; }

        /// <summary>
        /// 外部场景端业务订单
        /// </summary>
        [XmlElement("out_scene_biz_no")]
        public string OutSceneBizNo { get; set; }

        /// <summary>
        /// 平台方案合约号
        /// </summary>
        [XmlElement("platform_scheme_ar_no")]
        public string PlatformSchemeArNo { get; set; }

        /// <summary>
        /// 卖家方案合约号
        /// </summary>
        [XmlElement("seller_scheme_ar_no")]
        public string SellerSchemeArNo { get; set; }
    }
}
