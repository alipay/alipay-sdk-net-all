using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductionMaterial Data Structure.
    /// </summary>
    [Serializable]
    public class ProductionMaterial : AopObject
    {
        /// <summary>
        /// 碰一下跳转页面链接
        /// </summary>
        [XmlElement("coil_link_url")]
        public string CoilLinkUrl { get; set; }

        /// <summary>
        /// 物料上的桌号/序号信息
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [XmlElement("position_name")]
        public string PositionName { get; set; }

        /// <summary>
        /// 二维码链接
        /// </summary>
        [XmlElement("print_qr_code_url")]
        public string PrintQrCodeUrl { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("variable_ext_tr_info")]
        public string VariableExtTrInfo { get; set; }
    }
}
