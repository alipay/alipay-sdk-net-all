using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallRenfundorderQueryModel : AopObject
    {
        /// <summary>
        /// 纠纷id
        /// </summary>
        [XmlElement("dispute_id")]
        public string DisputeId { get; set; }
    }
}
