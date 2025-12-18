using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQualificationApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQualificationApplyModel : AopObject
    {
        /// <summary>
        /// 业务场景信息
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务号，幂等ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 资格ID
        /// </summary>
        [XmlElement("qual_id")]
        public string QualId { get; set; }

        /// <summary>
        /// 资格实例id
        /// </summary>
        [XmlElement("qual_instance_id")]
        public string QualInstanceId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
