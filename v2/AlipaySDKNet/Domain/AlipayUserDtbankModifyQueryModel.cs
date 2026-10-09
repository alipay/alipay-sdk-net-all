using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankModifyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankModifyQueryModel : AopObject
    {
        /// <summary>
        /// 数字分行活动唯一id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("api_out_biz_no")]
        public string ApiOutBizNo { get; set; }

        /// <summary>
        /// 修改类型：APPEND表示追加预算、DELAY表示活动延期；
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }
    }
}
