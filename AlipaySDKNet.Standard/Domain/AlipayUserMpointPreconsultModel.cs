using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointPreconsultModel : AopObject
    {
        /// <summary>
        /// 业务子类型，由会员方面分配
        /// </summary>
        [XmlElement("biz_sub_type")]
        public string BizSubType { get; set; }

        /// <summary>
        /// 业务类型，由会员方面分配
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 目标操作的分数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
