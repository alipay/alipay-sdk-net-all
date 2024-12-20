using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChinaMobileVerificationSyncData Data Structure.
    /// </summary>
    [Serializable]
    public class ChinaMobileVerificationSyncData : AopObject
    {
        /// <summary>
        /// 核销来源为收银台商家券时必填
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// status=1时，可以传失败原因
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 如果核销流水类型为后向同步，该字段必填
        /// </summary>
        [XmlElement("coupon")]
        public string Coupon { get; set; }

        /// <summary>
        /// 格式为yyyy-MM-dd HH:mm:ss； 若核销流水撤销标识=0，此值为核销完成时间 若核销流水撤销标识=1，此值为返销完成的时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// decimal(65,2)，支持两位小数；
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 需加密，加密方式与coupon字段一致
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 发放接口里面的订单号，即移动侧发放单号
        /// </summary>
        [XmlElement("order_item_id")]
        public string OrderItemId { get; set; }

        /// <summary>
        /// 需加密，加密方式与coupon字段一致
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// decimal(65,2)，支持两位小数；
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [XmlElement("retain")]
        public string Retain { get; set; }

        /// <summary>
        /// 发放接口里面的skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 0-分省平台；1-核销平台；2-权益方；3-收银台商家券 第三方对接时为2-权益方；4-小程序核销商家券
        /// </summary>
        [XmlElement("source")]
        public long Source { get; set; }

        /// <summary>
        /// 0-成功；1-失败 核销流水类型=0时，只需传成功状态的流水
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// decimal(65,2)，支持两位小数；
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 如果核销流水类型为实时流水同步，该字段必填，值为5.7申请核销信息接口返回的全网权益平台核销流水ID
        /// </summary>
        [XmlElement("verification_id")]
        public string VerificationId { get; set; }

        /// <summary>
        /// 券类型编码，即该类券在权益方侧的标识，用于区分是券包中的哪张券。非必传，若为券包类型权益必传
        /// </summary>
        [XmlElement("verification_skucode")]
        public string VerificationSkucode { get; set; }
    }
}
