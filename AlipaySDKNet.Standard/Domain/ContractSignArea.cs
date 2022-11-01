using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractSignArea Data Structure.
    /// </summary>
    [Serializable]
    public class ContractSignArea : AopObject
    {
        /// <summary>
        /// 签署区页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// x坐标
        /// </summary>
        [XmlElement("pos_x")]
        public string PosX { get; set; }

        /// <summary>
        /// y坐标
        /// </summary>
        [XmlElement("pos_y")]
        public string PosY { get; set; }

        /// <summary>
        /// 签署角色类型，个人=USER，企业=COMPANY
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 签署区宽度
        /// </summary>
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
