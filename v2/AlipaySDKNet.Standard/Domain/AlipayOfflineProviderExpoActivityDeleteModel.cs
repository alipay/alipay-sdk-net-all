using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoActivityDeleteModel : AopObject
    {
        /// <summary>
        /// 活动唯一编码（参考修改接口定义）
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }
    }
}
