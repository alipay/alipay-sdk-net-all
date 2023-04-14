using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPartnerPrivilegeMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPartnerPrivilegeMatchModel : AopObject
    {
        /// <summary>
        /// 当前用户注册成为合作商家会员（成为会员后可享有相应的特权）的时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 当前用户在合作商家体系中的会员等级英文编码，如 gloden（黄金会员)，primary（大众会员），如果商家没有会员等级概念，则默认为“member”
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 当前用户在商家侧的状态：1.激活会员-ACTIVE；2.关闭会员-CLOSE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
