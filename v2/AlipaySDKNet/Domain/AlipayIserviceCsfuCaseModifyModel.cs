using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCsfuCaseModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCsfuCaseModifyModel : AopObject
    {
        /// <summary>
        /// 案件数据主键id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 修改的信息内容
        /// </summary>
        [XmlElement("modified_info")]
        public string ModifiedInfo { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
