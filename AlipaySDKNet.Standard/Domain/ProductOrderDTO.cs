using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ProductOrderDTO : AopObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("inactive_datetime")]
        public string InactiveDatetime { get; set; }

        /// <summary>
        /// 订购编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购者支付宝ID
        /// </summary>
        [XmlElement("order_user_id")]
        public string OrderUserId { get; set; }

        /// <summary>
        /// 订购平台
        /// </summary>
        [XmlElement("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [XmlElement("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("prod_name")]
        public string ProdName { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// 签约活动
        /// </summary>
        [XmlElement("sign_activity_dto")]
        public SignActivityDTO SignActivityDto { get; set; }

        /// <summary>
        /// 合约状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
