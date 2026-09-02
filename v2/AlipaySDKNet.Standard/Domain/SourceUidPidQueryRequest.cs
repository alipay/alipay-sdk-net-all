using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SourceUidPidQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class SourceUidPidQueryRequest : AopObject
    {
        /// <summary>
        /// 主体编码 , 该参数可选，它的作用是：当为ZN7 时，若该source_uid的pid不存在需要去注册pid，注册后会同时也注册财资子户。
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 来源uid
        /// </summary>
        [XmlElement("source_uid")]
        public string SourceUid { get; set; }
    }
}
