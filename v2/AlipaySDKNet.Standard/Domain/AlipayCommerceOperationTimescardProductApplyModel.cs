using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTimescardProductApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTimescardProductApplyModel : AopObject
    {
        /// <summary>
        /// 预付宝：ALIPAY_YUFUBAO
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 字段已经废弃，无需传参
        /// </summary>
        [XmlElement("isv_partner_id")]
        public string IsvPartnerId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 字段已经废弃，无需传参
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 次卡资金结算信息
        /// </summary>
        [XmlElement("settle_info")]
        public FundSettleInfo SettleInfo { get; set; }
    }
}
