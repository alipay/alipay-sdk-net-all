using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateQueryResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益模版的可用金额，即总金额减去已结算金额
        /// </summary>
        [XmlElement("asset_amount")]
        public string AssetAmount { get; set; }

        /// <summary>
        /// 资产id，即权益模板的id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 权益模版的总金额，包含采购和追加的金额
        /// </summary>
        [XmlElement("asset_total_amount")]
        public string AssetTotalAmount { get; set; }

        /// <summary>
        /// 资产类型，由支付宝权益结算平台定义，BENEFIT_TEMPLATE表示权益模版
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 过期金额，单位元，部分场景有含义，具体咨询相关技术同学
        /// </summary>
        [XmlElement("expire_amount")]
        public string ExpireAmount { get; set; }

        /// <summary>
        /// 权益模版的过期时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 发放金额，单位元，部分场景有含义，具体咨询相关技术同学
        /// </summary>
        [XmlElement("publish_amount")]
        public string PublishAmount { get; set; }

        /// <summary>
        /// 已回收金额
        /// </summary>
        [XmlElement("recycle_amount")]
        public string RecycleAmount { get; set; }

        /// <summary>
        /// 权益模版回收时间，回收时间是资金退回的时间
        /// </summary>
        [XmlElement("recycle_dt")]
        public string RecycleDt { get; set; }

        /// <summary>
        /// 退款金额，单位元，部分场景有含义，具体咨询相关技术同学
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 权益模版状态： WAIT_EFFECTIVE:待生效，已创建未发布； EFFECTIVE:已发布; WAIT_RECYCLE:待回收，已过期未处理； RECYCLE:已回收
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 使用金额，单位元，即结算的金额
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 支付宝会员id，权益模板所属的商家的支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
