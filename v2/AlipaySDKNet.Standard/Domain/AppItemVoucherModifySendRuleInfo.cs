using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemVoucherModifySendRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemVoucherModifySendRuleInfo : AopObject
    {
        /// <summary>
        /// 券发放结束时间， 格式：yyyy-MM-dd HH:mm:ss 匹配格式yyyy-MM-dd HH:mm:ss的date类型
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }
    }
}
