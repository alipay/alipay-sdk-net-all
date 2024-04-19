using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingMaterialCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingMaterialCreateModel : AopObject
    {
        /// <summary>
        /// 素材字段列表，素材提报的具体内容，包含三种类型：图片、文本、链接。图片类型，则根据“图片资源上传接口（https://opendocs.alipay.com/pre-open/02bhlj）”中返回的resource_id字段值进行素材字段的设值。文本或链接类型，则按照实际需要设值即可，需满足具体的规范要求。规范要求详情请参见产品文档。
        /// </summary>
        [XmlArray("material_fields")]
        [XmlArrayItem("material_field")]
        public List<MaterialField> MaterialFields { get; set; }

        /// <summary>
        /// 素材名称，接入方自行生成，建议命名时遵循一定的规律以方便管理。
        /// </summary>
        [XmlElement("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 素材规范ID，用于标识具体场景下的素材规范，根据具体的使用场景获取对应的素材规范ID。
        /// </summary>
        [XmlElement("material_spec_id")]
        public string MaterialSpecId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制，相同单号会返回上一次的结果，接入方需保证单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
