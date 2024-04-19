using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenCloudAppProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenCloudAppProductQueryModel : AopObject
    {
        /// <summary>
        /// 需要查询的应用appId
        /// </summary>
        [XmlElement("invoke_app_id")]
        public string InvokeAppId { get; set; }
    }
}
