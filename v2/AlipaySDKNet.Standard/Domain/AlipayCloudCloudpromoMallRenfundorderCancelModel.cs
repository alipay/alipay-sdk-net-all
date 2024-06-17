using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallRenfundorderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallRenfundorderCancelModel : AopObject
    {
        /// <summary>
        /// 纠纷id
        /// </summary>
        [XmlElement("dispute_id")]
        public string DisputeId { get; set; }
    }
}
