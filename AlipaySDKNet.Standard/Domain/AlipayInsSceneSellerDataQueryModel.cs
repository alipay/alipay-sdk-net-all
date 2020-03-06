using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneSellerDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneSellerDataQueryModel : AopObject
    {
        /// <summary>
        /// 目标服务名称
        /// </summary>
        [XmlElement("dx_name")]
        public string DxName { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra_data")]
        public string ExtraData { get; set; }

        /// <summary>
        /// 机构产品号
        /// </summary>
        [XmlElement("prod_no")]
        public string ProdNo { get; set; }

        /// <summary>
        /// 标准产品号
        /// </summary>
        [XmlElement("sp_no")]
        public string SpNo { get; set; }
    }
}
