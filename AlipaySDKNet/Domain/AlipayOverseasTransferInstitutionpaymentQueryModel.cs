using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTransferInstitutionpaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTransferInstitutionpaymentQueryModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_scene_type")]
        public string BizSceneType { get; set; }

        /// <summary>
        /// 搜索关键字(学校名/机构ID)
        /// </summary>
        [XmlElement("institution_keyword")]
        public string InstitutionKeyword { get; set; }

        /// <summary>
        /// 收款机构所在国家，2位编码
        /// </summary>
        [XmlElement("institution_region")]
        public string InstitutionRegion { get; set; }

        /// <summary>
        /// 透传字段，json map格式
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
