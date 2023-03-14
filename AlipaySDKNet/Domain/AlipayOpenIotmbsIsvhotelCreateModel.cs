using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvhotelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvhotelCreateModel : AopObject
    {
        /// <summary>
        /// appid+酒店关联的appid，后面相应的小程序调用相关组件时用于鉴权,多个appid之间用,分割
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// area_code:酒店所在区县的编码
        /// </summary>
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// project_addr+酒店项目所处的详细地址
        /// </summary>
        [XmlElement("project_addr")]
        public string ProjectAddr { get; set; }

        /// <summary>
        /// project_flag用于标记创建的酒店是否是线上真实项目
        /// </summary>
        [XmlElement("project_flag")]
        public string ProjectFlag { get; set; }

        /// <summary>
        /// project_id，酒店项目id。
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// project_name+isv定义的酒店名
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }
    }
}
