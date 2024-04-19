using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureDeleteModel : AopObject
    {
        /// <summary>
        /// 行业编码。（注：该接口为定向开放接口，使用前需要与对应的"业务产品"申请，切勿随意填写）
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务流水id。（注：用于异常过程中排查定位问题）
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展信息，json串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 人脸库id。（注：人脸库id可通过“查询人脸库key接口”获取）
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 机构编号。（同：机构id/机构内标）
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// isv英文简称。（注：请不要填写中文名称）
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 人脸出库信息列表。
        /// </summary>
        [XmlArray("scenic_face_info")]
        [XmlArrayItem("scenic_face_info")]
        public List<ScenicFaceInfo> ScenicFaceInfo { get; set; }
    }
}
