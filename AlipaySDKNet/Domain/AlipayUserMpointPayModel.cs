using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserMpointPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserMpointPayModel : AopObject
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
        /// 业务流水号，会用于幂等性校验，所以请保证每次请求的业务流水号的唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 需要扣减的积分数
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }
    }
}
