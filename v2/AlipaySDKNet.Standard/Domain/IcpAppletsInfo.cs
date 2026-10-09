using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcpAppletsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IcpAppletsInfo : AopObject
    {
        /// <summary>
        /// 小程序附件材料凭证media_id（参考：备案文件材料上传接口）
        /// </summary>
        [XmlArray("attachement_materials")]
        [XmlArrayItem("string")]
        public List<string> AttachementMaterials { get; set; }

        /// <summary>
        /// 小程序备注
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 小程序前置审批项信息
        /// </summary>
        [XmlArray("icp_audit_infos")]
        [XmlArrayItem("icp_audit_info_list")]
        public List<IcpAuditInfoList> IcpAuditInfos { get; set; }

        /// <summary>
        /// 小程序服务内容标识（参考：获取服务内容标识的接口）
        /// </summary>
        [XmlElement("main_category_id")]
        public string MainCategoryId { get; set; }
    }
}
