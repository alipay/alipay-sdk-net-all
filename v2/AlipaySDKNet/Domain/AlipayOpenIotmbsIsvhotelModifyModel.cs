using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvhotelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvhotelModifyModel : AopObject
    {
        /// <summary>
        /// 酒店项目所处的地址
        /// </summary>
        [XmlElement("project_addr")]
        public string ProjectAddr { get; set; }

        /// <summary>
        /// project_flag+用于标记创建的酒店是否是线上真实项目
        /// </summary>
        [XmlElement("project_flag")]
        public string ProjectFlag { get; set; }

        /// <summary>
        /// 需要编辑的酒店的酒店id(机构外标)
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 酒店对外展示名称
        /// </summary>
        [XmlElement("project_nick_name")]
        public string ProjectNickName { get; set; }
    }
}
