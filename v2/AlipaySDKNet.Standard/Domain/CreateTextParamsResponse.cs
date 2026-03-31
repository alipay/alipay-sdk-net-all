using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateTextParamsResponse Data Structure.
    /// </summary>
    [Serializable]
    public class CreateTextParamsResponse : AopObject
    {
        /// <summary>
        /// 操作成功后完成标识为true
        /// </summary>
        [XmlElement("push_bailingual_flag")]
        public bool PushBailingualFlag { get; set; }
    }
}
