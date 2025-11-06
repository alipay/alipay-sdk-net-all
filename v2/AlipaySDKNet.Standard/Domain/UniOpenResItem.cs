using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UniOpenResItem Data Structure.
    /// </summary>
    [Serializable]
    public class UniOpenResItem : AopObject
    {
        /// <summary>
        /// 开通项结果详情
        /// </summary>
        [XmlElement("detail_infos")]
        public UniOpenResItemDetailInfos DetailInfos { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 开通类型
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 注：在异步通知中，只会存在明确结果的状态：SUCCESS、FAIL或RETRY
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
