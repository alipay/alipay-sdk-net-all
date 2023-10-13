using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourcePackageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ResourcePackageInfo : AopObject
    {
        /// <summary>
        /// 是否可以变配
        /// </summary>
        [XmlElement("can_alter")]
        public bool CanAlter { get; set; }

        /// <summary>
        /// 不能变配的原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 原始单价(分)
        /// </summary>
        [XmlElement("original_unit_amount")]
        public string OriginalUnitAmount { get; set; }

        /// <summary>
        /// 产品计费项列表
        /// </summary>
        [XmlArray("product_fee_items")]
        [XmlArrayItem("product_fee_item")]
        public List<ProductFeeItem> ProductFeeItems { get; set; }

        /// <summary>
        /// 资源包规格编码  - public_cloudd_cd_cn_free_bag(免费版)  - public_cloudd_cd_cn_base_bag(基础版)  - public_cloudd_cd_cn_standard_bag(标准版)  - public_cloudd_cd_cn_pro_bag(专业版)  - public_cloudd_cd_cn_ent_bag(企业版)  - public_cloudd_cd_cn_flagship_bag(旗舰版)
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 资源包规格描述
        /// </summary>
        [XmlElement("spec_desc")]
        public string SpecDesc { get; set; }

        /// <summary>
        /// 资源包规格名称
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 折扣后单价(分)
        /// </summary>
        [XmlElement("trade_unit_amount")]
        public string TradeUnitAmount { get; set; }
    }
}
