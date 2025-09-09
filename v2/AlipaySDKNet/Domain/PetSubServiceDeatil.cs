using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PetSubServiceDeatil Data Structure.
    /// </summary>
    [Serializable]
    public class PetSubServiceDeatil : AopObject
    {
        /// <summary>
        /// 实际时间
        /// </summary>
        [XmlElement("actual_time")]
        public string ActualTime { get; set; }

        /// <summary>
        /// 服务金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 预期时间
        /// </summary>
        [XmlElement("expect_time")]
        public string ExpectTime { get; set; }

        /// <summary>
        /// 其他扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务期数
        /// </summary>
        [XmlElement("period")]
        public string Period { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
