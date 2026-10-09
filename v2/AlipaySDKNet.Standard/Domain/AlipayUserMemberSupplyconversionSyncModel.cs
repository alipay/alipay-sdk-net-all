using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberSupplyconversionSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberSupplyconversionSyncModel : AopObject
    {
        /// <summary>
        /// 用户权益转化发生的时间。如用户问卷完成时间。
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 用于唯一标识一次权益转化
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 标识流量渠道
        /// </summary>
        [XmlElement("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 本次权益转化类型，由区域上翻研发分配。
        /// </summary>
        [XmlElement("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 蚂蚁open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 标识唯一一次用户权益点击
        /// </summary>
        [XmlElement("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
