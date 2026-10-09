using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserDtbankModifyQueryResponse.
    /// </summary>
    public class AlipayUserDtbankModifyQueryResponse : AopResponse
    {
        /// <summary>
        /// 修改活动类型，APPEND表示追加预算，DELAY表示活动延期
        /// </summary>
        [XmlElement("modify_type")]
        public string ModifyType { get; set; }

        /// <summary>
        /// 追加金额：单位分； 活动结束时间：精确到秒，格式为2020-01-01 00:00:00
        /// </summary>
        [XmlElement("modify_value")]
        public string ModifyValue { get; set; }

        /// <summary>
        /// 活动修改的结果，INIT表示处理中，SUCCESS表示成功，FAILED表示失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
