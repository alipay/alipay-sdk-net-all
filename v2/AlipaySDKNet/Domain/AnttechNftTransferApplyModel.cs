using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftTransferApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftTransferApplyModel : AopObject
    {
        /// <summary>
        /// 调用方渠道租户，传租户id即可
        /// </summary>
        [XmlElement("channel_tenant")]
        public string ChannelTenant { get; set; }

        /// <summary>
        /// 被转入用户的支付宝uid或手机号
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 参照idType
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户在商户购买的订单号，鲸探侧主要用来做幂等，调用方自己定义的幂等单据号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户购买价格，可以为0，单位分
        /// </summary>
        [XmlElement("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 请求唯一ID，用于链路跟踪和问题排查
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 藏品标识sku
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
