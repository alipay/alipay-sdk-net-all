using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoanapplyBkruralindustryMassifQueryResponse.
    /// </summary>
    public class MybankCreditLoanapplyBkruralindustryMassifQueryResponse : AopResponse
    {
        /// <summary>
        /// 地块列表信息
        /// </summary>
        [XmlArray("massif_info_list")]
        [XmlArrayItem("massif_base_info")]
        public List<MassifBaseInfo> MassifInfoList { get; set; }
    }
}
