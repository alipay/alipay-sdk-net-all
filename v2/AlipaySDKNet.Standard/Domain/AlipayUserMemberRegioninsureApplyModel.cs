using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMemberRegioninsureApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMemberRegioninsureApplyModel : AopObject
    {
        /// <summary>
        /// 商户openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 从插件获取的bizId
        /// </summary>
        [XmlElement("xlight_biz_id")]
        public string XlightBizId { get; set; }
    }
}
