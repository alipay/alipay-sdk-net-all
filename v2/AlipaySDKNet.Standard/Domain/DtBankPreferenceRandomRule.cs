using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankPreferenceRandomRule Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankPreferenceRandomRule : AopObject
    {
        /// <summary>
        /// 随机满减区间列表
        /// </summary>
        [XmlArray("range_info_list")]
        [XmlArrayItem("dt_bank_random_range_info")]
        public List<DtBankRandomRangeInfo> RangeInfoList { get; set; }
    }
}
