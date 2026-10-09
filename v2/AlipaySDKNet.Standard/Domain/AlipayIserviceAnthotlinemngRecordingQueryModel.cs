using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceAnthotlinemngRecordingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceAnthotlinemngRecordingQueryModel : AopObject
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务域权限验签
        /// </summary>
        [XmlElement("biz_sign")]
        public string BizSign { get; set; }

        /// <summary>
        /// 通话id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 热线渠道实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }
    }
}
