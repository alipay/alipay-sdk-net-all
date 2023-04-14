using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderParticipantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderParticipantInfo : AopObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("order_ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 参与方logo素材id 开发者通过 alipay.merchant.item.file.upload(商品文件上传接口)上传图片，获取到对应的素材 ID( material_id )
        /// </summary>
        [XmlElement("logo_material_id")]
        public string LogoMaterialId { get; set; }

        /// <summary>
        /// 参与方名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 参与方简称
        /// </summary>
        [XmlElement("short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// 参与方类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 参与方支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
