using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardExtensionInfoData Data Structure.
    /// </summary>
    [Serializable]
    public class CardExtensionInfoData : AopObject
    {
        /// <summary>
        /// 业务唯一标识符，定义本次响应请求唯一业务数据
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// json数据结构，具体不同业务响应数据可定义为map结构进行序列化后响应，详情字段第三方接入方与开发人员协商约定
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
