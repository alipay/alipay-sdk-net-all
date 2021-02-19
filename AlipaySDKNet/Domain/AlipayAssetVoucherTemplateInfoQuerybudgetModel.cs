using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQuerybudgetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetVoucherTemplateInfoQuerybudgetModel : AopObject
    {
        /// <summary>
        /// 是否查询实时数据，true：查询实时数据，false：查询非实时数据(5分钟延迟)
        /// </summary>
        [XmlElement("is_real_time_data")]
        public bool IsRealTimeData { get; set; }

        /// <summary>
        /// 预算类型，取值范围只能是MONEY、AMOUNT，MONEY代表金额预算，AMOUNT代表数量预算
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 券模板ID列表，请使用json数组格式
        /// </summary>
        [XmlElement("template_id_list")]
        public string TemplateIdList { get; set; }
    }
}
