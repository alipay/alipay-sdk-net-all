using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantPrivilegeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiMerchantPrivilegeSyncModel : AopObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 当前用户在商家侧的英文等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 当前等级的过期时间
        /// </summary>
        [XmlElement("grade_expired_time")]
        public string GradeExpiredTime { get; set; }

        /// <summary>
        /// 权益名称信息
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 用户Id信息
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用作幂等控制，注意同步不同的状态时，外部业务号必须不同，否则会被幂等掉，无法正确同步数据。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 注册渠道编码
        /// </summary>
        [XmlElement("register_channel")]
        public string RegisterChannel { get; set; }

        /// <summary>
        /// 当前用户消费商家特权的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户Id信息
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 当pid无法区分商家时，合作商家需要传递此字段
        /// </summary>
        [XmlElement("vendor")]
        public string Vendor { get; set; }
    }
}
