using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneChannelsaleVoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneChannelsaleVoucherCreateModel : AopObject
    {
        /// <summary>
        /// 凭证业务扩展字段
        /// </summary>
        [XmlElement("biz_data")]
        public InsOpenVoucherBizDataDTO BizData { get; set; }

        /// <summary>
        /// 渠道商户ID，由蚂蚁保统一分配
        /// </summary>
        [XmlElement("channel_merchant_id")]
        public string ChannelMerchantId { get; set; }

        /// <summary>
        /// 渠道商户类型，由蚂蚁保分配
        /// </summary>
        [XmlElement("channel_merchant_type")]
        public string ChannelMerchantType { get; set; }

        /// <summary>
        /// 操作人ID，实际操作凭证发放的人员ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部业务单号，外部关联本次发放凭证的唯一单据
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 合作商ID，由蚂蚁保统一分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 产品方案ID，由蚂蚁保分配
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 订购商户ID，由蚂蚁保统一分配
        /// </summary>
        [XmlElement("purchase_merchant_id")]
        public string PurchaseMerchantId { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }
    }
}
