using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreateMaterialsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreateMaterialsInfo : AopObject
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 该二维码需要的物料数量，单位个
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 用于描述物料的生产要素信息
        /// </summary>
        [XmlElement("production_ext_info")]
        public string ProductionExtInfo { get; set; }

        /// <summary>
        /// 二维码地址链接
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
