using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankActivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankActivityModifyModel : AopObject
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
        /// 修改类型：APPEND表示追加预算、DELAY表示活动延期
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 追加金额：单位分； 活动结束时间：精确到秒，格式为2020-01-01 00:00:00
        /// </summary>
        [XmlElement("modify_value")]
        public string ModifyValue { get; set; }
    }
}
