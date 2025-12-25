using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsExpressOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsExpressOrderQueryModel : AopObject
    {
        /// <summary>
        /// 该包裹的收件人手机后四位尾号
        /// </summary>
        [XmlElement("check_phone_no")]
        public string CheckPhoneNo { get; set; }

        /// <summary>
        /// 时间格式字符串，卡片过期时间,默认为当前时间延后5分钟
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 实际的物流公司编号
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 实际的物流运单号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
