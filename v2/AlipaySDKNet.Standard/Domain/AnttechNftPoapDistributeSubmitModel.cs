using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftPoapDistributeSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftPoapDistributeSubmitModel : AopObject
    {
        /// <summary>
        /// 业务单号,作为幂等校验
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务日期
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 勋章元数据ID
        /// </summary>
        [XmlElement("medal_meta_id")]
        public long MedalMetaId { get; set; }
    }
}
