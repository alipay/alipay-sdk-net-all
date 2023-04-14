using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmOlsChatrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmOlsChatrecordQueryModel : AopObject
    {
        /// <summary>
        /// 租户实例id（数据权限id），不填，则使用默认的租户实例id
        /// </summary>
        [XmlElement("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线服务记录id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
