using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspOrgQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspOrgQueryModel : AopObject
    {
        /// <summary>
        /// 签约主体外标id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 签约主体类型，1机构2机构集
        /// </summary>
        [XmlElement("entity_type")]
        public long EntityType { get; set; }

        /// <summary>
        /// isv的appId
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// isv的英文名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// isv的商户id
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }
    }
}
