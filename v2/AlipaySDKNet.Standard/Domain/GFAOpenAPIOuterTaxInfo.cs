using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIOuterTaxInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIOuterTaxInfo : AopObject
    {
        /// <summary>
        /// 外部计税明细列表，支持一费多税模式
        /// </summary>
        [XmlArray("tax_info_detail_list")]
        [XmlArrayItem("g_f_a_open_a_p_i_outer_tax_info_detail")]
        public List<GFAOpenAPIOuterTaxInfoDetail> TaxInfoDetailList { get; set; }
    }
}
