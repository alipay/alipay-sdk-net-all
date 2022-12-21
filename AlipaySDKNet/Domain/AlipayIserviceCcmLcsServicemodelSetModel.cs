using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmLcsServicemodelSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmLcsServicemodelSetModel : AopObject
    {
        /// <summary>
        /// 租户实例id（数据权限id），不填，则使用默认的租户实例id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 云客服服务模式code
        /// </summary>
        [XmlElement("service_mode")]
        public string ServiceMode { get; set; }
    }
}
