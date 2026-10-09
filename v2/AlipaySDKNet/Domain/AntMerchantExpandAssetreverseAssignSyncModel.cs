using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAssetreverseAssignSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAssetreverseAssignSyncModel : AopObject
    {
        /// <summary>
        /// 取消订单或退货指令接收反馈，最多200条
        /// </summary>
        [XmlArray("reverse_results")]
        [XmlArrayItem("asset_result")]
        public List<AssetResult> ReverseResults { get; set; }
    }
}
