using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotvspOrguserDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotvspOrguserDeleteModel : AopObject
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
        /// 人脸id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 人脸库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

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
        /// isv的pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }
    }
}
