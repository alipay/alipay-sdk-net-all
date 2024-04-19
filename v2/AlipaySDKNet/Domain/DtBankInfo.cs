using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DtBankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DtBankInfo : AopObject
    {
        /// <summary>
        /// 活动支持的银行机构列表
        /// </summary>
        [XmlArray("bank_inst_info_list")]
        [XmlArrayItem("dt_bank_inst_info")]
        public List<DtBankInstInfo> BankInstInfoList { get; set; }

        /// <summary>
        /// 活动支持的卡bin列表
        /// </summary>
        [XmlArray("card_bin_list")]
        [XmlArrayItem("string")]
        public List<string> CardBinList { get; set; }
    }
}
